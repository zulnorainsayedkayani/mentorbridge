namespace mentorbridge
{
    partial class frmStudentRegister
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
            lblUsername = new Label();
            lblField = new Label();
            lblGoal = new Label();
            lblSession = new Label();
            btnBack = new Button();
            btnSave = new Button();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            cmbField = new ComboBox();
            cmbGoal = new ComboBox();
            cmbSession = new ComboBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(185, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(409, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Registeration";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(165, 96);
            lblName.Name = "lblName";
            lblName.Size = new Size(102, 25);
            lblName.TabIndex = 1;
            lblName.Text = "FullName:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(185, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(160, 223);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(108, 25);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username:";
            // 
            // lblField
            // 
            lblField.AutoSize = true;
            lblField.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblField.Location = new Point(128, 282);
            lblField.Name = "lblField";
            lblField.Size = new Size(157, 25);
            lblField.TabIndex = 5;
            lblField.Text = "Field of Interest:";
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGoal.Location = new Point(151, 329);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(116, 25);
            lblGoal.TabIndex = 6;
            lblGoal.Text = "CareerGoal:";
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSession.Location = new Point(141, 374);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(133, 25);
            lblSession.TabIndex = 7;
            lblSession.Text = "Session Type:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SlateGray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(337, 459);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(194, 50);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back to login ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SlateGray;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(124, 459);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 50);
            btnSave.TabIndex = 9;
            btnSave.Text = "Register";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.HighlightText;
            txtName.Location = new Point(294, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 31);
            txtName.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Location = new Point(294, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 31);
            txtEmail.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLightLight;
            txtPassword.Location = new Point(294, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 31);
            txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.Location = new Point(294, 220);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 31);
            txtUsername.TabIndex = 13;
            // 
            // cmbField
            // 
            cmbField.BackColor = SystemColors.InactiveCaption;
            cmbField.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbField.FormattingEnabled = true;
            cmbField.Items.AddRange(new object[] { "Technology", "Marketing", "Design", "Business", "Finance" });
            cmbField.Location = new Point(294, 279);
            cmbField.Name = "cmbField";
            cmbField.Size = new Size(250, 33);
            cmbField.TabIndex = 14;
            // 
            // cmbGoal
            // 
            cmbGoal.BackColor = SystemColors.InactiveCaption;
            cmbGoal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGoal.FormattingEnabled = true;
            cmbGoal.Items.AddRange(new object[] { "job", "freelance", "Start-up ", "Further Studies " });
            cmbGoal.Location = new Point(294, 321);
            cmbGoal.Name = "cmbGoal";
            cmbGoal.Size = new Size(250, 33);
            cmbGoal.TabIndex = 15;
            // 
            // cmbSession
            // 
            cmbSession.BackColor = SystemColors.InactiveCaption;
            cmbSession.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSession.FormattingEnabled = true;
            cmbSession.Items.AddRange(new object[] { "online", "In- Person" });
            cmbSession.Location = new Point(294, 366);
            cmbSession.Name = "cmbSession";
            cmbSession.Size = new Size(250, 33);
            cmbSession.TabIndex = 16;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(165, 183);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(109, 25);
            lblPassword.TabIndex = 17;
            lblPassword.Text = "Password: ";
            // 
            // frmStudentRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(776, 521);
            Controls.Add(lblPassword);
            Controls.Add(cmbSession);
            Controls.Add(cmbGoal);
            Controls.Add(cmbField);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Controls.Add(lblSession);
            Controls.Add(lblGoal);
            Controls.Add(lblField);
            Controls.Add(lblUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "frmStudentRegister";
            Text = "frmStudentRegister";
            Load += frmStudentRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblEmail;
        
        private Label lblUsername;
        private Label lblField;
        private Label lblGoal;
        private Label lblSession;
        private Button btnBack;
        private Button btnSave;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private ComboBox cmbField;
        private ComboBox cmbGoal;
        private ComboBox cmbSession;
        private Label lblPassword;
    }
}