using System.Windows.Forms;
using scholarship_Application.Controls;

namespace scholarship_Application.Forms
{
    public class DashboardBase : Form
    {
        protected readonly Panel ContentPanel = new()
        {
            Dock = DockStyle.Fill,
            BackColor = Ui.Content,
            Padding = new Padding(10, 8, 10, 8),
        };

        private readonly List<Button> _navButtons = new();

        protected DashboardBase()
        {
            BackColor = Ui.Sidebar;
            Font = new Font("Segoe UI", 9.75F);
            Controls.Add(ContentPanel);
        }

        protected void RegisterNav(params Button[] navButtons) => _navButtons.AddRange(navButtons);

        protected void Activate(Button activeButton, Control screen)
        {
            foreach (Button button in _navButtons)
            {
                button.BackColor = Ui.Sidebar;
            }
            activeButton.BackColor = Ui.SidebarActive;

            ContentPanel.SuspendLayout();
            ContentPanel.Controls.Clear();

            screen.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(screen);

            ContentPanel.ResumeLayout();

            if (screen is IRefreshable refreshable)
            {
                refreshable.RefreshData();
            }
        }

        protected void LogoutTo(Form login)
        {
            DialogResult choice = MessageBox.Show(
                "Back to login?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (choice != DialogResult.Yes)
            {
                return;
            }

            login.Show();
            Close();
        }
    }
}
