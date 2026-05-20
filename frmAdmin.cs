using System;
using System.Data;
using System.Windows.Forms;

namespace mentorbridge
{
    public partial class frmAdmin : Form
    {
        // Track what is currently showing
        private string currentView = "Students";

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // Show counts
            UpdateCounts();

            // Style DataGridView
            dgvData.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ReadOnly = true;
            dgvData.AllowUserToAddRows = false;
            dgvData.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvData.BackgroundColor =
                System.Drawing.Color.White;
            dgvData.RowHeadersVisible = false;
            dgvData.AlternatingRowsDefaultCellStyle
                .BackColor = System.Drawing.Color.AliceBlue;

            // Load students by default
            LoadStudents();
        }

        private void UpdateCounts()
        {
            lblStudents.Text = "Total Students: " +
                DatabaseHelper.GetCount("Students");
            lblMentors.Text = "Total Mentors: " +
                DatabaseHelper.GetCount("Mentors");
            lblSessions.Text = "Total Sessions: " +
                DatabaseHelper.GetCount("Sessions");
        }

        private void LoadStudents()
        {
            currentView = "Students";
            dgvData.DataSource = null;
            DataTable dt =
                DatabaseHelper.GetAllStudentsTable();
            dgvData.DataSource = dt;
        }

        private void LoadMentors()
        {
            currentView = "Mentors";
            dgvData.DataSource = null;
            DataTable dt =
                DatabaseHelper.GetAllMentorsTable();
            dgvData.DataSource = dt;
        }

        private void LoadSessions()
        {
            currentView = "Sessions";
            dgvData.DataSource = null;
            DataTable dt =
                DatabaseHelper.GetAllSessionsTable();
            dgvData.DataSource = dt;
        }

        private void btnViewStudents_Click_1(
            object sender, EventArgs e)
        {
            LoadStudents();
        }


        private void btnDelete_Click_1(
            object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a row to delete!",
                    "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (currentView == "Sessions")
            {
                MessageBox.Show(
                    "Cannot delete sessions directly!",
                    "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                if (currentView == "Students")
                {
                    int studentID = Convert.ToInt32(
                        dgvData.SelectedRows[0]
                        .Cells["StudentID"].Value);
                    DatabaseHelper.DeleteStudent(studentID);
                    MessageBox.Show(
                        "Student deleted successfully!",
                        "Deleted", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadStudents();
                }
                else if (currentView == "Mentors")
                {
                    int mentorID = Convert.ToInt32(
                        dgvData.SelectedRows[0]
                        .Cells["MentorID"].Value);
                    DatabaseHelper.DeleteMentor(mentorID);
                    MessageBox.Show(
                        "Mentor deleted successfully!",
                        "Deleted", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadMentors();
                }

                UpdateCounts();
            }
        }

      

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            GlobalState.LoggedInUsername = "";
            GlobalState.LoggedInRole = "";

            frmlogin login = new frmlogin();
            login.Show();
            this.Close();
        }

        private void btnViewMentors_Click_1(object sender, EventArgs e)
        {
            LoadMentors();
        }

        private void btnViewSessions_Click_1(object sender, EventArgs e)
        {
            LoadSessions();
        }
    }
}