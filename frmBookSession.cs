using System;
using System.Windows.Forms;

namespace mentorbridge
{
    public partial class frmBookSession : Form
    {
        public frmBookSession()
        {
            InitializeComponent();
        }

        private void frmBookSession_Load(object sender, EventArgs e)
        {
            // Show matched mentor details
            if (GlobalState.MatchedMentor != null)
            {
                lblMentorName.Text =
                    "Mentor: " +
                    GlobalState.MatchedMentor.Name +
                    "\nExpertise: " +
                    GlobalState.MatchedMentor.Expertise +
                    "\nIndustry: " +
                    GlobalState.MatchedMentor.Industry +
                    "\nExperience: " +
                    GlobalState.MatchedMentor.Experience +
                    " years";
            }
            else
            {
                lblMentorName.Text = "No mentor matched!";
                btnBook.Enabled = false;
            }

            // Fill session type dropdown
            cmbSessionType.Items.AddRange(new string[]
            {
                "Online",
                "In-Person"
            });
            cmbSessionType.SelectedIndex = 0;

            // Minimum date is today
            dtpDate.MinDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            // Validation
            if (cmbSessionType.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select session type!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dtpDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Please select a valid date!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Get student from database
            int userID = DatabaseHelper.GetUserID(
                GlobalState.LoggedInUsername);

            if (userID == -1)
            {
                MessageBox.Show(
                    "Student not found!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Student s = DatabaseHelper
                .GetStudentByUserID(userID);

            if (s == null)
            {
                MessageBox.Show(
                    "Student profile not found!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Check if session already booked
            bool alreadyBooked = DatabaseHelper
                .IsSessionAlreadyBooked(
                    s.StudentID,
                    GlobalState.MatchedMentor.MentorID);

            if (alreadyBooked)
            {
                MessageBox.Show(
                    "You already have a session\n" +
                    "booked with this mentor!",
                    "Already Booked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Save session to database
            DatabaseHelper.SaveSession(
                s.StudentID,
                GlobalState.MatchedMentor.MentorID
            );

            // Show success message
            MessageBox.Show(
                "Session Booked Successfully!\n\n" +
                "Mentor: " +
                GlobalState.MatchedMentor.Name +
                "\nDate: " +
                dtpDate.Value.ToShortDateString() +
                "\nType: " +
                cmbSessionType.SelectedItem.ToString() +
                "\nStatus: Pending",
                "Booking Confirmed!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Go back to dashboard
            frmDashboard dash = new frmDashboard();
            dash.Show();
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.Show();
            this.Close();
        }
    }
}
