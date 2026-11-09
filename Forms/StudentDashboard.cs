using scholarship_Application.Controls;
using scholarship_Application.Data;

namespace scholarship_Application.Forms
{
    public partial class StudentDashboard : DashboardBase
    {
        private readonly LoginForm _login;

        public StudentDashboard(LoginForm login)
        {
            InitializeComponent();
            _login = login;
            RegisterNav(btnDashboard, btnApply, btnMyApplications);

            lblUserChip.Text = $"Signed in as\n{AppSession.FullName}";
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            Activate(btnDashboard, new StudentHomeControl());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Activate(btnDashboard, new StudentHomeControl());
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Activate(btnApply, new ApplyControl());
        }

        private void btnMyApplications_Click(object sender, EventArgs e)
        {
            Activate(btnMyApplications, new MyApplicationsControl());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutTo(_login);
            _login.Reset();
        }
    }
}
