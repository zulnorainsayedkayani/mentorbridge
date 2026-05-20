namespace mentorbridge
{
    partial class frmAdmin
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
            lblStudents = new Label();
            lblMentors = new Label();
            lblSessions = new Label();
            btnViewMentors = new Button();
            btnViewStudents = new Button();
            btnViewSessions = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(220, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(462, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mentor Bridge - Admin Panel";
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudents.Location = new Point(99, 78);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(165, 28);
            lblStudents.TabIndex = 2;
            lblStudents.Text = "Total Students:0";
            // 
            // lblMentors
            // 
            lblMentors.AutoSize = true;
            lblMentors.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMentors.Location = new Point(99, 125);
            lblMentors.Name = "lblMentors";
            lblMentors.Size = new Size(161, 28);
            lblMentors.TabIndex = 3;
            lblMentors.Text = "Total Mentors:0";
            // 
            // lblSessions
            // 
            lblSessions.AutoSize = true;
            lblSessions.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSessions.Location = new Point(99, 178);
            lblSessions.Name = "lblSessions";
            lblSessions.Size = new Size(161, 28);
            lblSessions.TabIndex = 4;
            lblSessions.Text = "Total Sessions:0";
            // 
            // btnViewMentors
            // 
            btnViewMentors.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewMentors.Location = new Point(291, 223);
            btnViewMentors.Name = "btnViewMentors";
            btnViewMentors.Size = new Size(170, 40);
            btnViewMentors.TabIndex = 5;
            btnViewMentors.Text = "View All Mentors";
            btnViewMentors.UseVisualStyleBackColor = true;
            btnViewMentors.Click += btnViewMentors_Click_1;
            // 
            // btnViewStudents
            // 
            btnViewStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewStudents.Location = new Point(90, 223);
            btnViewStudents.Name = "btnViewStudents";
            btnViewStudents.Size = new Size(170, 40);
            btnViewStudents.TabIndex = 6;
            btnViewStudents.Text = "View All Students";
            btnViewStudents.UseVisualStyleBackColor = true;
            btnViewStudents.Click += btnViewStudents_Click_1;
            // 
            // btnViewSessions
            // 
            btnViewSessions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewSessions.Location = new Point(495, 223);
            btnViewSessions.Name = "btnViewSessions";
            btnViewSessions.Size = new Size(170, 40);
            btnViewSessions.TabIndex = 7;
            btnViewSessions.Text = "View All Sessions";
            btnViewSessions.UseVisualStyleBackColor = true;
            btnViewSessions.Click += btnViewSessions_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(172, 269);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 40);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "DeleteSelected";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(406, 269);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(170, 40);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(27, 315);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 62;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(903, 134);
            dgvData.TabIndex = 10;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(953, 456);
            Controls.Add(dgvData);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnViewSessions);
            Controls.Add(btnViewStudents);
            Controls.Add(btnViewMentors);
            Controls.Add(lblSessions);
            Controls.Add(lblMentors);
            Controls.Add(lblStudents);
            Controls.Add(lblTitle);
            Name = "frmAdmin";
            Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStudents;
        private Label lblMentors;
        private Label lblSessions;
        private Button btnViewMentors;
        private Button btnViewStudents;
        private Button btnViewSessions;
        private Button btnDelete;
        private Button btnLogout;
        private DataGridView dgvData;
    }
}