using scholarship_Application.Controls;

namespace scholarship_Application.Forms
{
    public partial class AdminDashboard : DashboardBase
    {
        private readonly LoginForm _login;

        public AdminDashboard(LoginForm login)
        {
            InitializeComponent();
            _login = login;
            RegisterNav(btnDashboard, btnApplications);

            lblUserChip.Text = "Signed in as\nadmin (sample)";
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Activate(btnDashboard, new AdminHomeControl());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Activate(btnDashboard, new AdminHomeControl());
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            Activate(btnApplications, new AdminApplicationsControl());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutTo(_login);
            _login.Reset();
        }
    }
}
