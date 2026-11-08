namespace scholarship_Application.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
            txtUsername.Focus();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (username.Length == 0)
            {
                lblError.Text = "Type a username to continue.";
                txtUsername.Focus();
                return;
            }

            DashboardBase shell = username.StartsWith("admin", StringComparison.OrdinalIgnoreCase)
                ? (DashboardBase)new AdminDashboard(this)
                : new StudentDashboard(this);

            shell.FormClosed += (_, _) =>
            {
                if (!IsDisposed && !Visible)
                {
                    Application.Exit();
                }
            };

            Hide();
            shell.Show();

            txtPassword.Clear();
            lblError.Text = "";
        }

        public void Reset()
        {
            Show();
            txtPassword.Clear();
            txtUsername.SelectAll();
            txtUsername.Focus();
        }

        
    }
}
