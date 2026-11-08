namespace scholarship_Application.Forms
{
    partial class StudentDashboard
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
            this.sidebar = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblUserChip = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnMyApplications = new System.Windows.Forms.Button();
            this.pnlFiller = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(1, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(223, 54);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tarlac City Scholarship Portal";
            this.lblUserChip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserChip.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblUserChip.ForeColor = System.Drawing.Color.FromArgb(150, 170, 200);
            this.lblUserChip.Location = new System.Drawing.Point(1, 57);
            this.lblUserChip.Name = "lblUserChip";
            this.lblUserChip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblUserChip.Size = new System.Drawing.Size(223, 28);
            this.lblUserChip.TabIndex = 1;
            this.lblUserChip.Text = "";
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(24, 41, 74);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 63, 108);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(1, 87);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(223, 46);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(24, 41, 74);
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 63, 108);
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(1, 135);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(223, 46);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "   Apply";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            this.btnMyApplications.BackColor = System.Drawing.Color.FromArgb(24, 41, 74);
            this.btnMyApplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMyApplications.FlatAppearance.BorderSize = 0;
            this.btnMyApplications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 63, 108);
            this.btnMyApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyApplications.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnMyApplications.ForeColor = System.Drawing.Color.White;
            this.btnMyApplications.Location = new System.Drawing.Point(1, 183);
            this.btnMyApplications.Name = "btnMyApplications";
            this.btnMyApplications.Size = new System.Drawing.Size(223, 46);
            this.btnMyApplications.TabIndex = 4;
            this.btnMyApplications.Text = "   My Applications";
            this.btnMyApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyApplications.UseVisualStyleBackColor = false;
            this.btnMyApplications.Click += new System.EventHandler(this.btnMyApplications_Click);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(199, 56, 56);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1, 595);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(223, 46);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.pnlFiller.BackColor = System.Drawing.Color.FromArgb(24, 41, 74);
            this.pnlFiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiller.Location = new System.Drawing.Point(1, 231);
            this.pnlFiller.Name = "pnlFiller";
            this.pnlFiller.Size = new System.Drawing.Size(223, 362);
            this.pnlFiller.TabIndex = 5;
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(24, 41, 74);
            this.sidebar.ColumnCount = 1;
            this.sidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.sidebar.Controls.Add(this.lblHeader, 0, 0);
            this.sidebar.Controls.Add(this.lblUserChip, 0, 1);
            this.sidebar.Controls.Add(this.btnDashboard, 0, 2);
            this.sidebar.Controls.Add(this.btnApply, 0, 3);
            this.sidebar.Controls.Add(this.btnMyApplications, 0, 4);
            this.sidebar.Controls.Add(this.pnlFiller, 0, 5);
            this.sidebar.Controls.Add(this.btnLogout, 0, 6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.RowCount = 7;
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46));
            this.sidebar.Size = new System.Drawing.Size(225, 660);
            this.sidebar.TabIndex = 1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(24, 41, 74);
            this.ClientSize = new System.Drawing.Size(1120, 660);
            this.Controls.Add(this.sidebar);
            this.MinimumSize = new System.Drawing.Size(980, 620);
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarlac City Scholarship Portal - Student";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }


        private System.Windows.Forms.TableLayoutPanel sidebar;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblUserChip;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnMyApplications;
        private System.Windows.Forms.Panel pnlFiller;
        private System.Windows.Forms.Button btnLogout;
    }
}

