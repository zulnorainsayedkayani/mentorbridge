namespace mentorbridge
{
    partial class frmDashboard
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
            lblWelcome = new Label();
            lblRole = new Label();
            lblMentor = new Label();
            btnMyBookings = new Button();
            btnViewRequests = new Button();
            btnBookSession = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(21, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(188, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MentorBridge";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(152, 47);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(166, 45);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(81, 86);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(54, 28);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role:";
            // 
            // lblMentor
            // 
            lblMentor.AutoSize = true;
            lblMentor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMentor.Location = new Point(114, 114);
            lblMentor.Name = "lblMentor";
            lblMentor.Size = new Size(225, 28);
            lblMentor.TabIndex = 3;
            lblMentor.Text = "Your Matched Mentor:";
            // 
            // btnMyBookings
            // 
            btnMyBookings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyBookings.Location = new Point(152, 242);
            btnMyBookings.Name = "btnMyBookings";
            btnMyBookings.Size = new Size(261, 40);
            btnMyBookings.TabIndex = 5;
            btnMyBookings.Text = "My Bookings";
            btnMyBookings.UseVisualStyleBackColor = true;
            btnMyBookings.Click += btnMyBookings_Click_1;
            // 
            // btnViewRequests
            // 
            btnViewRequests.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewRequests.Location = new Point(152, 297);
            btnViewRequests.Name = "btnViewRequests";
            btnViewRequests.Size = new Size(261, 40);
            btnViewRequests.TabIndex = 6;
            btnViewRequests.Text = "View Requests";
            btnViewRequests.UseVisualStyleBackColor = true;
            btnViewRequests.Click += btnViewRequests_Click_1;
            // 
            // btnBookSession
            // 
            btnBookSession.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookSession.Location = new Point(152, 354);
            btnBookSession.Name = "btnBookSession";
            btnBookSession.Size = new Size(261, 40);
            btnBookSession.TabIndex = 7;
            btnBookSession.Text = "Book Session";
            btnBookSession.UseVisualStyleBackColor = true;
            btnBookSession.Click += btnBookSession_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(189, 427);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 40);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(722, 507);
            Controls.Add(btnLogout);
            Controls.Add(btnBookSession);
            Controls.Add(btnViewRequests);
            Controls.Add(btnMyBookings);
            Controls.Add(lblMentor);
            Controls.Add(lblRole);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MentorBridge-Dashboard";
            Load += frmDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblWelcome;
        private Label lblRole;
        private Label lblMentor;
        private Button btnMyBookings;
        private Button btnViewRequests;
        private Button btnBookSession;
        private Button btnLogout;
    }
}