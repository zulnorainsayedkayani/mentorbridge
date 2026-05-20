using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace mentorbridge
{
    public class DatabaseHelper
    {
        private static string connStr =
            "Data Source=" +
            System.IO.Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.ApplicationData), "mentorbridge.db") +
       ";Version=3;"+"Pooling=False;";

        public static void InitializeDatabase()
        {
            SQLiteConnection.ClearAllPools();
            GC.Collect();
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = @"
                        CREATE TABLE IF NOT EXISTS Users (
                            UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT,
                            Password TEXT,
                            Role TEXT);

                        CREATE TABLE IF NOT EXISTS Students (
                            StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT,
                            Email TEXT,
                            Password TEXT,
                            Field TEXT,
                            CareerGoal TEXT,
                            SessionType TEXT,
                            UserID INTEGER);

                        CREATE TABLE IF NOT EXISTS Mentors (
                            MentorID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT,
                            Email TEXT,
                            Password TEXT,
                            Industry TEXT,
                            Expertise TEXT,
                            Experience INTEGER,
                            Availability TEXT,
                            MaxStudents INTEGER,
                            AverageRating REAL,
                            UserID INTEGER);

                        CREATE TABLE IF NOT EXISTS Sessions (
                            SessionID INTEGER PRIMARY KEY AUTOINCREMENT,
                            StudentID INTEGER,
                            MentorID INTEGER,
                            Status TEXT,
                            RequestDate TEXT);

                        CREATE TABLE IF NOT EXISTS Feedback (
                            FeedbackID INTEGER PRIMARY KEY AUTOINCREMENT,
                            SessionID INTEGER,
                            StudentID INTEGER,
                            MentorID INTEGER,
                            Rating INTEGER,
                            Comments TEXT,
                            FeedbackDate TEXT);";

                    new SQLiteCommand(sql, conn).ExecuteNonQuery();
                    // Add default admin account automatically
                    string checkAdmin =
                        "SELECT COUNT(*) FROM Users WHERE Role='Admin'";
                    int adminExists = Convert.ToInt32(
                        new SQLiteCommand(checkAdmin, conn)
                        .ExecuteScalar());

                    if (adminExists == 0)
                    {
                        string hash = BCrypt.Net.BCrypt
                            .HashPassword("admin123");
                        string addAdmin = @"INSERT INTO Users 
        (Username, Password, Role) 
        VALUES ('admin', @p, 'Admin')";
                        var adminCmd = new SQLiteCommand(addAdmin, conn);
                        adminCmd.Parameters.AddWithValue("@p", hash);
                        adminCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
        
        public static string LoginUser(string username, string password)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT Password, Role FROM Users WHERE Username=@u";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string storedHash = reader["Password"].ToString();
                        string role = reader["Role"].ToString();
                        bool isMatch = BCrypt.Net.BCrypt.Verify(password, storedHash);

                        if (isMatch)
                            return role;
                        else
                            return null;
                    }
                    return null;  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
                return null;
            }
        }

        public static int SaveUser(string username,
     string password, string role)
        {
            try
            {
                
                string hashedPassword =
                    BCrypt.Net.BCrypt.HashPassword(password);

                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();

                    string sql = @"INSERT INTO Users 
                (Username, Password, Role) 
                VALUES (@u, @p, @r);
                SELECT last_insert_rowid();";

                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", hashedPassword);
                    cmd.Parameters.AddWithValue("@r", role);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save User Error: " + ex.Message);
                return -1;
            }
        }

        public static void SaveStudent(Student s, int userID)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Students 
                                   (Name, Email, Password, Field, CareerGoal, SessionType, UserID)
                                   VALUES (@n, @e, @p, @f, @g, @st, @uid)";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@n", s.Name);
                    cmd.Parameters.AddWithValue("@e", s.Email);
                    cmd.Parameters.AddWithValue("@p", s.Password);
                    cmd.Parameters.AddWithValue("@f", s.FieldOfInterest);
                    cmd.Parameters.AddWithValue("@g", s.CareerGoal);
                    cmd.Parameters.AddWithValue("@st", s.SessionType);
                    cmd.Parameters.AddWithValue("@uid", userID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Student Error: " + ex.Message);
            }
        }

        public static void SaveMentor(Mentor m, int userID)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Mentors 
                                   (Name, Email, Password, Industry, Expertise, 
                                    Experience, Availability, MaxStudents, UserID)
                                   VALUES (@n, @e, @p, @i, @ex, @exp, @av, @ms, @uid)";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@n", m.Name);
                    cmd.Parameters.AddWithValue("@e", m.Email);
                    cmd.Parameters.AddWithValue("@p", m.Password);
                    cmd.Parameters.AddWithValue("@i", m.Industry);
                    cmd.Parameters.AddWithValue("@ex", m.Expertise);
                    cmd.Parameters.AddWithValue("@exp", m.Experience);
                    cmd.Parameters.AddWithValue("@av", m.Availability);
                    cmd.Parameters.AddWithValue("@ms", m.MaxStudents);
                    cmd.Parameters.AddWithValue("@uid", userID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Mentor Error: " + ex.Message);
            }
        }

        public static Student GetStudentByUserID(int userID)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Students WHERE UserID=@uid";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@uid", userID);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Student
                        {
                            StudentID = Convert.ToInt32(reader["StudentID"]),
                            Name = reader["Name"].ToString() ?? string.Empty,
                            Email = reader["Email"].ToString() ?? string.Empty,
                            FieldOfInterest = reader["Field"].ToString() ?? string.Empty,
                            CareerGoal = reader["CareerGoal"].ToString() ?? string.Empty,
                            SessionType = reader["SessionType"].ToString() ?? string.Empty,
                        };
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get Student Error: " + ex.Message);
                return null;
            }
        }

        public static Mentor GetMentorByUserID(int userID)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Mentors WHERE UserID=@uid";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@uid", userID);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Mentor
                        {
                            MentorID = Convert.ToInt32(reader["MentorID"]),
                            Name = reader["Name"].ToString()??string.Empty,
                            Email = reader["Email"].ToString() ?? string.Empty,
                            Industry = reader["Industry"].ToString() ?? string.Empty,
                            Expertise = reader["Expertise"].ToString() ?? string.Empty,
                            Experience = Convert.ToInt32(reader["Experience"]),
                            Availability = reader["Availability"].ToString() ?? string.Empty,
                            MaxStudents = Convert.ToInt32(reader["MaxStudents"]),
                            AverageRating = Convert.ToDouble(reader["AverageRating"])
                        };
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get Mentor Error: " + ex.Message);
                return null;
            }
        }

        public static List<Mentor> GetAllMentors()
        {
            var list = new List<Mentor>();
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    var reader = new SQLiteCommand(
                        "SELECT * FROM Mentors", conn).ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Mentor
                        {
                            MentorID = Convert.ToInt32(reader["MentorID"]),
                            Name = reader["Name"].ToString() ?? string.Empty,
                            Industry = reader["Industry"].ToString() ?? string.Empty,
                            Expertise = reader["Expertise"].ToString() ?? string.Empty,
                            Experience = reader["Experience"]==DBNull.Value ? 0 : Convert.ToInt32(reader["Experience"]),
                            Availability = reader["Availability"].ToString() ?? string.Empty,
                            MaxStudents = reader["MaxStudents"]==DBNull.Value? 0 : Convert.ToInt32(reader["MaxStudents"]),
                            AverageRating = reader["AverageRating"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["AverageRating"]),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get Mentors Error: " + ex.Message);
            }
            return list;
        }

        public static void SaveSession(int studentID, int mentorID)
        {
            SQLiteConnection.ClearAllPools();
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Sessions 
                                   (StudentID, MentorID, Status, RequestDate)
                                   VALUES (@sid, @mid, 'Pending', @date)";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@sid", studentID);
                    cmd.Parameters.AddWithValue("@mid", mentorID);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd/MM/yyyy"));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Session Error: " + ex.Message);
            }
        }

       
        
        public static int GetUserID(string username)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT UserID FROM Users WHERE Username=@u";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    var result = cmd.ExecuteScalar();
                    return result != null ?
                        Convert.ToInt32(result) : -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return -1;
            }
        }
        public static string GetStudentBookings(int studentID)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT s.Name, ss.Status, ss.RequestDate 
                          FROM Sessions ss
                          JOIN Mentors s ON ss.MentorID = s.MentorID
                          WHERE ss.StudentID = @sid";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@sid", studentID);
                    var reader = cmd.ExecuteReader();

                    string result = "";
                    while (reader.Read())
                    {
                        result += "Mentor: " + reader["Name"] +
                                 "\nStatus: " + reader["Status"] +
                                 "\nDate: " + reader["RequestDate"] +
                                 "\n─────────────\n";
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "";
            }
        }

        public static string GetMentorRequests(int mentorID)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT s.Name, ss.Status, ss.RequestDate 
                          FROM Sessions ss
                          JOIN Students s ON ss.StudentID = s.StudentID
                          WHERE ss.MentorID = @mid";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@mid", mentorID);
                    var reader = cmd.ExecuteReader();

                    string result = "";
                    while (reader.Read())
                    {
                        result += "Student: " + reader["Name"] +
                                 "\nStatus: " + reader["Status"] +
                                 "\nDate: " + reader["RequestDate"] +
                                 "\n─────────────\n";
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "";
            }
        }
        public static bool IsSessionAlreadyBooked(
    int studentID, int mentorID)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT COUNT(*) FROM Sessions 
                          WHERE StudentID=@sid 
                          AND MentorID=@mid";
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@sid", studentID);
                    cmd.Parameters.AddWithValue("@mid", mentorID);
                    int count = Convert.ToInt32(
                        cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public static int GetCount(string tableName)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM " + tableName;
                    int count = Convert.ToInt32(
                        new SQLiteCommand(sql, conn).ExecuteScalar());
                    conn.Close();
                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
        }

        public static DataTable GetAllStudentsTable()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT s.StudentID, s.Name,
                s.Email, s.Field as FieldOfInterest,
                s.CareerGoal, s.SessionType, u.Username
                FROM Students s
                JOIN Users u ON s.UserID = u.UserID";
                    var adapter = new SQLiteDataAdapter(sql, conn);
                    adapter.Fill(dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }

        public static DataTable GetAllMentorsTable()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT m.MentorID, m.Name,
                m.Email, m.Industry, m.Expertise,
                m.Experience, m.Availability,
                m.MaxStudents, u.Username
                FROM Mentors m
                JOIN Users u ON m.UserID = u.UserID";
                    var adapter = new SQLiteDataAdapter(sql, conn);
                    adapter.Fill(dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }

        public static DataTable GetAllSessionsTable()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT ss.SessionID,
                st.Name as StudentName,
                m.Name as MentorName,
                ss.Status, ss.RequestDate
                FROM Sessions ss
                JOIN Students st
                    ON ss.StudentID = st.StudentID
                JOIN Mentors m
                    ON ss.MentorID = m.MentorID";
                    var adapter = new SQLiteDataAdapter(sql, conn);
                    adapter.Fill(dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }

        public static void DeleteStudent(int studentID)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string getUser =
                        "SELECT UserID FROM Students WHERE StudentID=@id";
                    var getCmd = new SQLiteCommand(getUser, conn);
                    getCmd.Parameters.AddWithValue("@id", studentID);
                    int userID = Convert.ToInt32(getCmd.ExecuteScalar());

                    var delS = new SQLiteCommand(
                        "DELETE FROM Students WHERE StudentID=@id", conn);
                    delS.Parameters.AddWithValue("@id", studentID);
                    delS.ExecuteNonQuery();

                    var delU = new SQLiteCommand(
                        "DELETE FROM Users WHERE UserID=@uid", conn);
                    delU.Parameters.AddWithValue("@uid", userID);
                    delU.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message);
            }
        }

        public static void DeleteMentor(int mentorID)
        {
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string getUser =
                        "SELECT UserID FROM Mentors WHERE MentorID=@id";
                    var getCmd = new SQLiteCommand(getUser, conn);
                    getCmd.Parameters.AddWithValue("@id", mentorID);
                    int userID = Convert.ToInt32(getCmd.ExecuteScalar());

                    var delM = new SQLiteCommand(
                        "DELETE FROM Mentors WHERE MentorID=@id", conn);
                    delM.Parameters.AddWithValue("@id", mentorID);
                    delM.ExecuteNonQuery();

                    var delU = new SQLiteCommand(
                        "DELETE FROM Users WHERE UserID=@uid", conn);
                    delU.Parameters.AddWithValue("@uid", userID);
                    delU.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message);
            }
        }
    }
}



