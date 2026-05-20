using System;
using System.Windows.Forms;

namespace mentorbridge
{
    public partial class frmMentorRegister : Form
    {
        public frmMentorRegister()
        {
            InitializeComponent();
        }

        private void frmMentorRegister_Load(object sender, EventArgs e)
        {

            cmbIndustry.Items.AddRange(new string[]
            {
                "Technology",
                "Marketing",
                "Design",
                "Business",
                "Finance",

            });


            cmbExpertise.Items.AddRange(new string[]
            {


                "Technology",
                "Marketing",
                "Design",
                "Business",
                "Finance",

            });


            cmbAvailability.Items.AddRange(new string[]
            {
                "Weekdays",
                "Weekends",
                "Weekdays and Weekends",
                "Flexible"
            });


            nudExperience.Minimum = 1;
            nudExperience.Maximum = 10;
            nudExperience.Value = 1;

            nudMaxStudents.Minimum = 1;
            nudMaxStudents.Maximum = 20;
            nudMaxStudents.Value = 1;


            txtPassword.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void nudMaxStudents_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnbacktologin_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Close();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtPassword.Text) ||
               string.IsNullOrWhiteSpace(txtUsername.Text) ||
               cmbIndustry.SelectedItem == null ||
               cmbExpertise.SelectedItem == null ||
               cmbAvailability.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!",
                    "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            int userID = DatabaseHelper.SaveUser(
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim(),
                "Mentor"
            );

            if (userID == -1)
            {
                MessageBox.Show("Registration failed! Try again.",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            Mentor m = new Mentor
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Industry = cmbIndustry.SelectedItem.ToString(),
                Expertise = cmbExpertise.SelectedItem.ToString(),
                Experience = (int)nudExperience.Value,
                Availability = cmbAvailability.SelectedItem.ToString(),
                MaxStudents = (int)nudMaxStudents.Value
            };


            DatabaseHelper.SaveMentor(m, userID);

            MessageBox.Show(
                "Mentor Registered Successfully!\nYou can now login.",
                "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            frmlogin login = new frmlogin();
            login.Show();
            this.Close();

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}