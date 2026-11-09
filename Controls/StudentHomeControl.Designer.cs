namespace scholarship_Application.Controls
{
    partial class StudentHomeControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            lblHeading = new Label();
            lblWelcome = new Label();
            pnlCards = new TableLayoutPanel();
            pnlCardSubmitted = new Panel();
            lblSubmittedValue = new Label();
            lblSubmittedCaption = new Label();
            lblStripeSubmitted = new Label();
            pnlCardApproved = new Panel();
            lblApprovedValue = new Label();
            lblApprovedCaption = new Label();
            lblStripeApproved = new Label();
            pnlCardRejected = new Panel();
            lblRejectedValue = new Label();
            lblRejectedCaption = new Label();
            lblStripeRejected = new Label();
            pnlCenter = new TableLayoutPanel();
            grpPrograms = new GroupBox();
            lstPrograms = new ListBox();
            grpAnnouncements = new GroupBox();
            lstAnnouncements = new ListBox();
            pnlCards.SuspendLayout();
            pnlCardSubmitted.SuspendLayout();
            pnlCardApproved.SuspendLayout();
            pnlCardRejected.SuspendLayout();
            pnlCenter.SuspendLayout();
            grpPrograms.SuspendLayout();
            grpAnnouncements.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Dock = DockStyle.Top;
            lblHeading.Font = new Font("Segoe UI Semibold", 13F);
            lblHeading.ForeColor = Color.FromArgb(24, 41, 74);
            lblHeading.Location = new Point(0, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Padding = new Padding(16, 6, 0, 3);
            lblHeading.Size = new Size(117, 34);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Dashboard";
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(24, 41, 74);
            lblWelcome.Location = new Point(0, 127);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Padding = new Padding(16, 2, 0, 0);
            lblWelcome.Size = new Size(700, 30);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome!";
            // 
            // pnlCards
            // 
            pnlCards.ColumnCount = 3;
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            pnlCards.Controls.Add(pnlCardSubmitted, 0, 0);
            pnlCards.Controls.Add(pnlCardApproved, 1, 0);
            pnlCards.Controls.Add(pnlCardRejected, 2, 0);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(0, 34);
            pnlCards.Margin = new Padding(3, 2, 3, 2);
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new Padding(4, 3, 7, 3);
            pnlCards.RowCount = 1;
            pnlCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlCards.Size = new Size(700, 93);
            pnlCards.TabIndex = 1;
            // 
            // pnlCardSubmitted
            // 
            pnlCardSubmitted.BackColor = Color.White;
            pnlCardSubmitted.Controls.Add(lblSubmittedValue);
            pnlCardSubmitted.Controls.Add(lblSubmittedCaption);
            pnlCardSubmitted.Controls.Add(lblStripeSubmitted);
            pnlCardSubmitted.Dock = DockStyle.Fill;
            pnlCardSubmitted.Location = new Point(8, 3);
            pnlCardSubmitted.Margin = new Padding(4, 0, 4, 0);
            pnlCardSubmitted.Name = "pnlCardSubmitted";
            pnlCardSubmitted.Size = new Size(221, 87);
            pnlCardSubmitted.TabIndex = 0;
            // 
            // lblSubmittedValue
            // 
            lblSubmittedValue.Dock = DockStyle.Fill;
            lblSubmittedValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSubmittedValue.ForeColor = Color.FromArgb(23, 93, 186);
            lblSubmittedValue.Location = new Point(0, 25);
            lblSubmittedValue.Name = "lblSubmittedValue";
            lblSubmittedValue.Padding = new Padding(12, 0, 0, 0);
            lblSubmittedValue.Size = new Size(221, 62);
            lblSubmittedValue.TabIndex = 0;
            lblSubmittedValue.Text = "0";
            lblSubmittedValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubmittedCaption
            // 
            lblSubmittedCaption.Dock = DockStyle.Top;
            lblSubmittedCaption.Font = new Font("Segoe UI", 9F);
            lblSubmittedCaption.ForeColor = Color.FromArgb(105, 115, 130);
            lblSubmittedCaption.Location = new Point(0, 4);
            lblSubmittedCaption.Name = "lblSubmittedCaption";
            lblSubmittedCaption.Padding = new Padding(12, 4, 0, 0);
            lblSubmittedCaption.Size = new Size(221, 21);
            lblSubmittedCaption.TabIndex = 1;
            lblSubmittedCaption.Text = "Submitted / under review";
            // 
            // lblStripeSubmitted
            // 
            lblStripeSubmitted.BackColor = Color.FromArgb(23, 93, 186);
            lblStripeSubmitted.Dock = DockStyle.Top;
            lblStripeSubmitted.Location = new Point(0, 0);
            lblStripeSubmitted.Name = "lblStripeSubmitted";
            lblStripeSubmitted.Size = new Size(221, 4);
            lblStripeSubmitted.TabIndex = 2;
            // 
            // pnlCardApproved
            // 
            pnlCardApproved.BackColor = Color.White;
            pnlCardApproved.Controls.Add(lblApprovedValue);
            pnlCardApproved.Controls.Add(lblApprovedCaption);
            pnlCardApproved.Controls.Add(lblStripeApproved);
            pnlCardApproved.Dock = DockStyle.Fill;
            pnlCardApproved.Location = new Point(237, 3);
            pnlCardApproved.Margin = new Padding(4, 0, 4, 0);
            pnlCardApproved.Name = "pnlCardApproved";
            pnlCardApproved.Size = new Size(221, 87);
            pnlCardApproved.TabIndex = 1;
            // 
            // lblApprovedValue
            // 
            lblApprovedValue.Dock = DockStyle.Fill;
            lblApprovedValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblApprovedValue.ForeColor = Color.FromArgb(28, 132, 74);
            lblApprovedValue.Location = new Point(0, 25);
            lblApprovedValue.Name = "lblApprovedValue";
            lblApprovedValue.Padding = new Padding(12, 0, 0, 0);
            lblApprovedValue.Size = new Size(221, 62);
            lblApprovedValue.TabIndex = 0;
            lblApprovedValue.Text = "0";
            lblApprovedValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblApprovedCaption
            // 
            lblApprovedCaption.Dock = DockStyle.Top;
            lblApprovedCaption.Font = new Font("Segoe UI", 9F);
            lblApprovedCaption.ForeColor = Color.FromArgb(105, 115, 130);
            lblApprovedCaption.Location = new Point(0, 4);
            lblApprovedCaption.Name = "lblApprovedCaption";
            lblApprovedCaption.Padding = new Padding(12, 4, 0, 0);
            lblApprovedCaption.Size = new Size(221, 21);
            lblApprovedCaption.TabIndex = 1;
            lblApprovedCaption.Text = "Approved";
            // 
            // lblStripeApproved
            // 
            lblStripeApproved.BackColor = Color.FromArgb(28, 132, 74);
            lblStripeApproved.Dock = DockStyle.Top;
            lblStripeApproved.Location = new Point(0, 0);
            lblStripeApproved.Name = "lblStripeApproved";
            lblStripeApproved.Size = new Size(221, 4);
            lblStripeApproved.TabIndex = 2;
            // 
            // pnlCardRejected
            // 
            pnlCardRejected.BackColor = Color.White;
            pnlCardRejected.Controls.Add(lblRejectedValue);
            pnlCardRejected.Controls.Add(lblRejectedCaption);
            pnlCardRejected.Controls.Add(lblStripeRejected);
            pnlCardRejected.Dock = DockStyle.Fill;
            pnlCardRejected.Location = new Point(466, 3);
            pnlCardRejected.Margin = new Padding(4, 0, 4, 0);
            pnlCardRejected.Name = "pnlCardRejected";
            pnlCardRejected.Size = new Size(223, 87);
            pnlCardRejected.TabIndex = 2;
            // 
            // lblRejectedValue
            // 
            lblRejectedValue.Dock = DockStyle.Fill;
            lblRejectedValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRejectedValue.ForeColor = Color.FromArgb(199, 56, 56);
            lblRejectedValue.Location = new Point(0, 25);
            lblRejectedValue.Name = "lblRejectedValue";
            lblRejectedValue.Padding = new Padding(12, 0, 0, 0);
            lblRejectedValue.Size = new Size(223, 62);
            lblRejectedValue.TabIndex = 0;
            lblRejectedValue.Text = "0";
            lblRejectedValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRejectedCaption
            // 
            lblRejectedCaption.Dock = DockStyle.Top;
            lblRejectedCaption.Font = new Font("Segoe UI", 9F);
            lblRejectedCaption.ForeColor = Color.FromArgb(105, 115, 130);
            lblRejectedCaption.Location = new Point(0, 4);
            lblRejectedCaption.Name = "lblRejectedCaption";
            lblRejectedCaption.Padding = new Padding(12, 4, 0, 0);
            lblRejectedCaption.Size = new Size(223, 21);
            lblRejectedCaption.TabIndex = 1;
            lblRejectedCaption.Text = "Rejected";
            // 
            // lblStripeRejected
            // 
            lblStripeRejected.BackColor = Color.FromArgb(199, 56, 56);
            lblStripeRejected.Dock = DockStyle.Top;
            lblStripeRejected.Location = new Point(0, 0);
            lblStripeRejected.Name = "lblStripeRejected";
            lblStripeRejected.Size = new Size(223, 4);
            lblStripeRejected.TabIndex = 2;
            // 
            // pnlCenter
            // 
            pnlCenter.BackColor = Color.FromArgb(243, 245, 249);
            pnlCenter.ColumnCount = 2;
            pnlCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlCenter.Controls.Add(grpPrograms, 0, 0);
            pnlCenter.Controls.Add(grpAnnouncements, 1, 0);
            pnlCenter.Dock = DockStyle.Fill;
            pnlCenter.Location = new Point(0, 157);
            pnlCenter.Margin = new Padding(3, 2, 3, 2);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Padding = new Padding(9, 2, 9, 8);
            pnlCenter.RowCount = 1;
            pnlCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlCenter.Size = new Size(700, 263);
            pnlCenter.TabIndex = 2;
            // 
            // grpPrograms
            // 
            grpPrograms.Controls.Add(lstPrograms);
            grpPrograms.Dock = DockStyle.Fill;
            grpPrograms.Font = new Font("Segoe UI Semibold", 10.5F);
            grpPrograms.ForeColor = Color.FromArgb(24, 41, 74);
            grpPrograms.Location = new Point(12, 4);
            grpPrograms.Margin = new Padding(3, 2, 3, 2);
            grpPrograms.Name = "grpPrograms";
            grpPrograms.Padding = new Padding(9, 8, 9, 8);
            grpPrograms.Size = new Size(335, 249);
            grpPrograms.TabIndex = 0;
            grpPrograms.TabStop = false;
            grpPrograms.Text = "Available scholarship programs";
            // 
            // lstPrograms
            // 
            lstPrograms.BorderStyle = BorderStyle.None;
            lstPrograms.Dock = DockStyle.Fill;
            lstPrograms.Font = new Font("Segoe UI", 9.5F);
            lstPrograms.IntegralHeight = false;
            lstPrograms.Location = new Point(9, 27);
            lstPrograms.Margin = new Padding(3, 2, 3, 2);
            lstPrograms.Name = "lstPrograms";
            lstPrograms.Size = new Size(317, 214);
            lstPrograms.TabIndex = 0;
            // 
            // grpAnnouncements
            // 
            grpAnnouncements.Controls.Add(lstAnnouncements);
            grpAnnouncements.Dock = DockStyle.Fill;
            grpAnnouncements.Font = new Font("Segoe UI Semibold", 10.5F);
            grpAnnouncements.ForeColor = Color.FromArgb(24, 41, 74);
            grpAnnouncements.Location = new Point(353, 4);
            grpAnnouncements.Margin = new Padding(3, 2, 3, 2);
            grpAnnouncements.Name = "grpAnnouncements";
            grpAnnouncements.Padding = new Padding(9, 8, 9, 8);
            grpAnnouncements.Size = new Size(335, 249);
            grpAnnouncements.TabIndex = 1;
            grpAnnouncements.TabStop = false;
            grpAnnouncements.Text = "Announcements";
            // 
            // lstAnnouncements
            // 
            lstAnnouncements.BorderStyle = BorderStyle.None;
            lstAnnouncements.Dock = DockStyle.Fill;
            lstAnnouncements.Font = new Font("Segoe UI", 9.5F);
            lstAnnouncements.IntegralHeight = false;
            lstAnnouncements.Location = new Point(9, 27);
            lstAnnouncements.Margin = new Padding(3, 2, 3, 2);
            lstAnnouncements.Name = "lstAnnouncements";
            lstAnnouncements.Size = new Size(317, 214);
            lstAnnouncements.TabIndex = 0;
            // 
            // StudentHomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 245, 249);
            Controls.Add(pnlCenter);
            Controls.Add(lblWelcome);
            Controls.Add(pnlCards);
            Controls.Add(lblHeading);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentHomeControl";
            Size = new Size(700, 420);
            pnlCards.ResumeLayout(false);
            pnlCardSubmitted.ResumeLayout(false);
            pnlCardApproved.ResumeLayout(false);
            pnlCardRejected.ResumeLayout(false);
            pnlCenter.ResumeLayout(false);
            grpPrograms.ResumeLayout(false);
            grpAnnouncements.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TableLayoutPanel pnlCards;
        private System.Windows.Forms.Panel pnlCardSubmitted;
        private System.Windows.Forms.Label lblSubmittedValue;
        private System.Windows.Forms.Label lblSubmittedCaption;
        private System.Windows.Forms.Label lblStripeSubmitted;
        private System.Windows.Forms.Panel pnlCardApproved;
        private System.Windows.Forms.Label lblApprovedValue;
        private System.Windows.Forms.Label lblApprovedCaption;
        private System.Windows.Forms.Label lblStripeApproved;
        private System.Windows.Forms.Panel pnlCardRejected;
        private System.Windows.Forms.Label lblRejectedValue;
        private System.Windows.Forms.Label lblRejectedCaption;
        private System.Windows.Forms.Label lblStripeRejected;
        private System.Windows.Forms.TableLayoutPanel pnlCenter;
        private System.Windows.Forms.GroupBox grpPrograms;
        private System.Windows.Forms.ListBox lstPrograms;
        private System.Windows.Forms.GroupBox grpAnnouncements;
        private System.Windows.Forms.ListBox lstAnnouncements;
    }
}
