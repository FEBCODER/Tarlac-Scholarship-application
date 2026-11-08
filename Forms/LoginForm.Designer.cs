namespace scholarship_Application.Forms
{
    partial class LoginForm
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
            pnlMain = new Panel();
            lblBrand = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUserEmail = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShow = new CheckBox();
            lblError = new Label();
            btnSignIn = new Button();
            lblHelper = new Label();
            pnlBanner = new Panel();
            lblBannerTitle = new Label();
            lblBannerQuote = new Label();
            pnlMain.SuspendLayout();
            pnlBanner.SuspendLayout();
            SuspendLayout();
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(lblBrand);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(lblSubtitle);
            pnlMain.Controls.Add(lblUserEmail);
            pnlMain.Controls.Add(txtUsername);
            pnlMain.Controls.Add(lblPassword);
            pnlMain.Controls.Add(txtPassword);
            pnlMain.Controls.Add(chkShow);
            pnlMain.Controls.Add(lblError);
            pnlMain.Controls.Add(btnSignIn);
            pnlMain.Controls.Add(lblHelper);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(3, 2, 3, 2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(482, 420);
            pnlMain.TabIndex = 1;
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Semibold", 9F);
            lblBrand.ForeColor = Color.FromArgb(23, 93, 186);
            lblBrand.Location = new Point(42, 63);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(178, 15);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "CITY GOVERNMENT OF TARLAC";
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(24, 41, 74);
            lblTitle.Location = new Point(42, 81);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Scholarship";
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(105, 115, 130);
            lblSubtitle.Location = new Point(42, 119);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(316, 15);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Application and Management System - sign in to continue";
            lblUserEmail.AutoSize = true;
            lblUserEmail.Font = new Font("Segoe UI Semibold", 9.25F);
            lblUserEmail.ForeColor = Color.FromArgb(45, 52, 66);
            lblUserEmail.Location = new Point(42, 147);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(122, 17);
            lblUserEmail.TabIndex = 3;
            lblUserEmail.Text = "Username or email";
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(42, 164);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(289, 27);
            txtUsername.TabIndex = 4;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9.25F);
            lblPassword.ForeColor = Color.FromArgb(45, 52, 66);
            lblPassword.Location = new Point(42, 196);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 17);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(42, 213);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(289, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            chkShow.AutoSize = true;
            chkShow.Font = new Font("Segoe UI", 8.75F);
            chkShow.ForeColor = Color.FromArgb(105, 115, 130);
            chkShow.Location = new Point(42, 242);
            chkShow.Margin = new Padding(3, 2, 3, 2);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(108, 19);
            chkShow.TabIndex = 7;
            chkShow.Text = "Show password";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            lblError.ForeColor = Color.FromArgb(199, 56, 56);
            lblError.Location = new Point(42, 261);
            lblError.Name = "lblError";
            lblError.Size = new Size(289, 16);
            lblError.TabIndex = 8;
            btnSignIn.BackColor = Color.FromArgb(23, 93, 186);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(42, 282);
            btnSignIn.Margin = new Padding(3, 2, 3, 2);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(289, 32);
            btnSignIn.TabIndex = 9;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            lblHelper.Location = new Point(0, 0);
            lblHelper.Name = "lblHelper";
            lblHelper.Size = new Size(100, 23);
            lblHelper.TabIndex = 10;
            pnlBanner.BackColor = Color.FromArgb(24, 41, 74);
            pnlBanner.Controls.Add(lblBannerTitle);
            pnlBanner.Controls.Add(lblBannerQuote);
            pnlBanner.Dock = DockStyle.Right;
            pnlBanner.Location = new Point(482, 0);
            pnlBanner.Margin = new Padding(3, 2, 3, 2);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(236, 420);
            pnlBanner.TabIndex = 0;
            lblBannerTitle.AutoSize = true;
            lblBannerTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBannerTitle.ForeColor = Color.White;
            lblBannerTitle.Location = new Point(21, 126);
            lblBannerTitle.Name = "lblBannerTitle";
            lblBannerTitle.Size = new Size(100, 25);
            lblBannerTitle.TabIndex = 0;
            lblBannerTitle.Text = "Tarlac City";
            lblBannerQuote.ForeColor = Color.FromArgb(150, 168, 196);
            lblBannerQuote.Location = new Point(21, 152);
            lblBannerQuote.Name = "lblBannerQuote";
            lblBannerQuote.Size = new Size(192, 56);
            lblBannerQuote.TabIndex = 1;
            lblBannerQuote.Text = "Every Tarlaceno student deserves a chance to finish school.";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(718, 420);
            Controls.Add(pnlMain);
            Controls.Add(pnlBanner);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarlac City Government Scholarship System";
            Load += LoginForm_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlBanner.ResumeLayout(false);
            pnlBanner.PerformLayout();
            ResumeLayout(false);
        }


        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblHelper;
        private System.Windows.Forms.Label lblBannerTitle;
        private System.Windows.Forms.Label lblBannerQuote;
    }
}
