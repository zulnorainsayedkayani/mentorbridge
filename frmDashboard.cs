using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mentorbridge
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " +
                GlobalState.LoggedInUsername + "!";
            lblRole.Text = "Role: " +
                GlobalState.LoggedInRole;

            if (GlobalState.LoggedInRole == "Student")
            {
                int userID = DatabaseHelper.GetUserID(
                    GlobalState.LoggedInUsername);
                Student s = DatabaseHelper
                    .GetStudentByUserID(userID);

                if (s != null)
                {
                    List<Mentor> matches = MatchEngine
                        .FindMatchingMentors(s.FieldOfInterest);

                    if (matches.Count > 0)
                    {
                        GlobalState.MatchedMentor = matches[0];
                        lblMentor.Text =
                            "Your Matched Mentor: " +
                            matches[0].Name +
                            "\nExpertise: " +
                            matches[0].Expertise +
                            "\nIndustry: " +
                            matches[0].Industry;
                    }
                    else
                    {
                        lblMentor.Text =
                            "No mentor matched yet.";
                        btnBookSession.Enabled = false;
                    }
                }

                btnMyBookings.Visible = true;
                btnBookSession.Visible = true;
                btnViewRequests.Visible = false;
            }
            else
            {
                int userID = DatabaseHelper.GetUserID(
                    GlobalState.LoggedInUsername);
                Mentor m = DatabaseHelper
                    .GetMentorByUserID(userID);

                if (m != null)
                {
                    lblMentor.Text =
                        "Your Expertise: " + m.Expertise +
                        "\nIndustry: " + m.Industry +
                        "\nExperience: " + m.Experience +
                        " years";
                }

                btnMyBookings.Visible = false;
                btnBookSession.Visible = false;
                btnViewRequests.Visible = true;
            }
        }

       

        private void btnMyBookings_Click_1(object sender, EventArgs e)
        {
            // Show student's booked sessions
            int userID = DatabaseHelper.GetUserID(
                GlobalState.LoggedInUsername);
            Student s = DatabaseHelper.GetStudentByUserID(userID);

            if (s != null)
            {
                string bookings = DatabaseHelper
                    .GetStudentBookings(s.StudentID);

                if (string.IsNullOrEmpty(bookings))
                    MessageBox.Show("No bookings yet!",
                        "My Bookings");
                else
                    MessageBox.Show(bookings, "My Bookings");
            }
        }

        private void btnViewRequests_Click_1(object sender, EventArgs e)
        {
            // Show mentor's session requests
            int userID = DatabaseHelper.GetUserID(
                GlobalState.LoggedInUsername);
            Mentor m = DatabaseHelper.GetMentorByUserID(userID);

            if (m != null)
            {
                string requests = DatabaseHelper
                    .GetMentorRequests(m.MentorID);

                if (string.IsNullOrEmpty(requests))
                    MessageBox.Show("No session requests yet!",
                        "Session Requests");
                else
                    MessageBox.Show(requests,
                        "Session Requests");
            }
        }

        private void btnBookSession_Click_1(object sender, EventArgs e)
        {

            if (GlobalState.MatchedMentor == null)
            {
                MessageBox.Show("No mentor matched yet!",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            frmBookSession book = new frmBookSession();
            book.Show();
            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {

            GlobalState.LoggedInUsername = "";
            GlobalState.LoggedInRole = "";
            GlobalState.MatchedMentor = null;

            frmlogin login = new frmlogin();
            login.Show();
            this.Close();
        }
    }
}
