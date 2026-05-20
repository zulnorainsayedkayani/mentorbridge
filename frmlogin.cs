using System;
using System.Windows.Forms;

namespace mentorbridge
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();



            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || role == null)
            {
                MessageBox.Show("Please fill all fields!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string returnedRole = DatabaseHelper.LoginUser(
                username, password);

            if (returnedRole == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (returnedRole != role)
            {
                MessageBox.Show("Role does not match.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GlobalState.LoggedInUsername = username;
            GlobalState.LoggedInRole = returnedRole;

            MessageBox.Show("Login successful.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (returnedRole == "Student")
            {
                frmDashboard dash = new frmDashboard();
                dash.Show();
                this.Hide();
            }
            else if (returnedRole == "Mentor")
            {
                frmDashboard dash = new frmDashboard();
                dash.Show();
                this.Hide();
            }
            else if (returnedRole == "Admin")
            {
                frmAdmin admin = new frmAdmin();
                admin.Show();
                this.Hide();
            }
        }



        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string role = cmbRole.SelectedItem?.ToString();

            if (role == null)
            {
                MessageBox.Show("Please select Student or Mentor first!",
                    "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (role == "Student")
            {
                frmStudentRegister reg = new frmStudentRegister();
                reg.Show();
                this.Hide();
            }
            else if (role == "Mentor")
            {
                frmMentorRegister reg = new frmMentorRegister();
                reg.Show();
                this.Hide();
            }
            else if (role == "Admin")
            {
                MessageBox.Show(
                    "Admin cannot register!\nPlease login directly.","Info",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}

    