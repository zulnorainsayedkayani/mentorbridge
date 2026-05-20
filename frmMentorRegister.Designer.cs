namespace mentorbridge
{
    partial class frmMentorRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblIndustry = new Label();
            lblExpertise = new Label();
            lblExperience = new Label();
            lblAvailability = new Label();
            lblMaxStudents = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            cmbIndustry = new ComboBox();
            cmbExpertise = new ComboBox();
            nudExperience = new NumericUpDown();
            cmbAvailability = new ComboBox();
            nudMaxStudents = new NumericUpDown();
            btnRegister = new Button();
            btnbacktologin = new Button();
            ((System.ComponentModel.ISupportInitialize)nudExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxStudents).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(181, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mentor Registeration";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(161, 84);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(196, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(171, 183);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(156, 225);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(112, 25);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username : ";
            // 
            // lblIndustry
            // 
            lblIndustry.AutoSize = true;
            lblIndustry.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndustry.Location = new Point(156, 267);
            lblIndustry.Name = "lblIndustry";
            lblIndustry.Size = new Size(89, 25);
            lblIndustry.TabIndex = 5;
            lblIndustry.Text = "Industry:";
            // 
            // lblExpertise
            // 
            lblExpertise.AutoSize = true;
            lblExpertise.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpertise.Location = new Point(156, 311);
            lblExpertise.Name = "lblExpertise";
            lblExpertise.Size = new Size(101, 25);
            lblExpertise.TabIndex = 6;
            lblExpertise.Text = "Expertise :";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExperience.Location = new Point(149, 358);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(110, 25);
            lblExperience.TabIndex = 7;
            lblExperience.Text = "Experience:";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailability.Location = new Point(144, 404);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(113, 25);
            lblAvailability.TabIndex = 8;
            lblAvailability.Text = "Availability:";
            // 
            // lblMaxStudents
            // 
            lblMaxStudents.AutoSize = true;
            lblMaxStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxStudents.Location = new Point(123, 445);
            lblMaxStudents.Name = "lblMaxStudents";
            lblMaxStudents.Size = new Size(134, 25);
            lblMaxStudents.TabIndex = 9;
            lblMaxStudents.Text = "Max Students:";
            // 
            // txtName
            // 
            txtName.Location = new Point(284, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 31);
            txtName.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(284, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 31);
            txtEmail.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(284, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 31);
            txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(284, 222);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 31);
            txtUsername.TabIndex = 13;
            // 
            // cmbIndustry
            // 
            cmbIndustry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIndustry.FormattingEnabled = true;
            cmbIndustry.Location = new Point(284, 259);
            cmbIndustry.Name = "cmbIndustry";
            cmbIndustry.Size = new Size(220, 33);
            cmbIndustry.TabIndex = 14;
            // 
            // cmbExpertise
            // 
            cmbExpertise.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExpertise.FormattingEnabled = true;
            cmbExpertise.Location = new Point(284, 303);
            cmbExpertise.Name = "cmbExpertise";
            cmbExpertise.Size = new Size(220, 33);
            cmbExpertise.TabIndex = 15;
            // 
            // nudExperience
            // 
            nudExperience.Location = new Point(284, 352);
            nudExperience.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudExperience.Name = "nudExperience";
            nudExperience.Size = new Size(220, 31);
            nudExperience.TabIndex = 16;
            nudExperience.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbAvailability
            // 
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Location = new Point(284, 396);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(220, 33);
            cmbAvailability.TabIndex = 17;
            // 
            // nudMaxStudents
            // 
            nudMaxStudents.Location = new Point(284, 439);
            nudMaxStudents.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudMaxStudents.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxStudents.Name = "nudMaxStudents";
            nudMaxStudents.Size = new Size(220, 31);
            nudMaxStudents.TabIndex = 18;
            nudMaxStudents.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxStudents.ValueChanged += nudMaxStudents_ValueChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ControlLightLight;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(132, 489);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 40);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // btnbacktologin
            // 
            btnbacktologin.BackColor = SystemColors.ControlLightLight;
            btnbacktologin.FlatStyle = FlatStyle.Flat;
            btnbacktologin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbacktologin.Location = new Point(315, 489);
            btnbacktologin.Name = "btnbacktologin";
            btnbacktologin.Size = new Size(189, 40);
            btnbacktologin.TabIndex = 20;
            btnbacktologin.Text = "Back to Login";
            btnbacktologin.UseVisualStyleBackColor = false;
            btnbacktologin.Click += btnbacktologin_Click;
            // 
            // frmMentorRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(812, 564);
            Controls.Add(btnbacktologin);
            Controls.Add(btnRegister);
            Controls.Add(nudMaxStudents);
            Controls.Add(cmbAvailability);
            Controls.Add(nudExperience);
            Controls.Add(cmbExpertise);
            Controls.Add(cmbIndustry);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblMaxStudents);
            Controls.Add(lblAvailability);
            Controls.Add(lblExperience);
            Controls.Add(lblExpertise);
            Controls.Add(lblIndustry);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "frmMentorRegister";
            Text = "MentorRegisteration";
            Load += frmMentorRegister_Load;
            ((System.ComponentModel.ISupportInitialize)nudExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblIndustry;
        private Label lblExpertise;
        private Label lblExperience;
        private Label lblAvailability;
        private Label lblMaxStudents;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private ComboBox cmbIndustry;
        private ComboBox cmbExpertise;
        private NumericUpDown nudExperience;
        private ComboBox cmbAvailability;
        private NumericUpDown nudMaxStudents;
        private Button btnRegister;
        private Button btnbacktologin;
    }
}