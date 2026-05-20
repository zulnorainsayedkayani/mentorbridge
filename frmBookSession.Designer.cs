namespace mentorbridge
{
    partial class frmBookSession
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
            lblMentorName = new Label();
            lblDate = new Label();
            lblSession = new Label();
            dtpDate = new DateTimePicker();
            cmbSessionType = new ComboBox();
            btnBook = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ButtonShadow;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ImageAlign = ContentAlignment.TopCenter;
            lblTitle.Location = new Point(193, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(241, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book a session";
            // 
            // lblMentorName
            // 
            lblMentorName.AutoSize = true;
            lblMentorName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMentorName.Location = new Point(193, 67);
            lblMentorName.Name = "lblMentorName";
            lblMentorName.Size = new Size(97, 30);
            lblMentorName.TabIndex = 1;
            lblMentorName.Text = "Mentor:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ImageAlign = ContentAlignment.MiddleLeft;
            lblDate.Location = new Point(44, 225);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(136, 30);
            lblDate.TabIndex = 2;
            lblDate.Text = "Select Date:";
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSession.Location = new Point(44, 273);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(151, 30);
            lblSession.TabIndex = 3;
            lblSession.Text = "Session Type:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(193, 224);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(291, 31);
            dtpDate.TabIndex = 4;
            // 
            // cmbSessionType
            // 
            cmbSessionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSessionType.FormattingEnabled = true;
            cmbSessionType.Location = new Point(214, 270);
            cmbSessionType.Name = "cmbSessionType";
            cmbSessionType.Size = new Size(220, 33);
            cmbSessionType.TabIndex = 5;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(88, 339);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(202, 34);
            btnBook.TabIndex = 6;
            btnBook.Text = "BOOK Session ";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click_1;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(362, 339);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // frmBookSession
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(716, 440);
            Controls.Add(btnBack);
            Controls.Add(btnBook);
            Controls.Add(cmbSessionType);
            Controls.Add(dtpDate);
            Controls.Add(lblSession);
            Controls.Add(lblDate);
            Controls.Add(lblMentorName);
            Controls.Add(lblTitle);
            Name = "frmBookSession";
            Text = "frmBookSession";
            Load += frmBookSession_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMentorName;
        private Label lblDate;
        private Label lblSession;
        private DateTimePicker dtpDate;
        private ComboBox cmbSessionType;
        private Button btnBook;
        private Button btnBack;
    }
}