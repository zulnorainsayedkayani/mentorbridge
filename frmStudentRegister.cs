using System;
using System.Windows.Forms;

namespace mentorbridge
{
    public partial class frmStudentRegister : Form
    {
        public frmStudentRegister()
        {
            InitializeComponent();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                cmbField.SelectedItem == null ||
                cmbGoal.SelectedItem == null ||
                cmbSession.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 1: Save to Users table FIRST
            int userID = DatabaseHelper.SaveUser(
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim(),
                "Student"
            );

            if (userID == -1)
            {
                MessageBox.Show("Registration failed!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Save to Students table
            Student s = new Student
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                FieldOfInterest = cmbField.SelectedItem.ToString(),
                CareerGoal = cmbGoal.SelectedItem.ToString(),
                SessionType = cmbSession.SelectedItem.ToString()
            };

            DatabaseHelper.SaveStudent(s, userID);

            MessageBox.Show("Student Registered Successfully!\nYou can now login.",
                "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            frmlogin login = new frmlogin();
            login.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Close();
        }

        private void frmStudentRegister_Load(object sender, EventArgs e)
        {

        }

       
    }
}