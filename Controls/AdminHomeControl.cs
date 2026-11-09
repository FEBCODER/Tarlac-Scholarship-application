using System.Windows.Forms;
using scholarship_Application.Data;
using scholarship_Application.Models;

namespace scholarship_Application.Controls
{
    public partial class AdminHomeControl : UserControl, IRefreshable
    {
        public AdminHomeControl()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            List<ScholarshipApplication> applications = AppRepository.List(null, "All");

            lblTotalValue.Text = applications.Count.ToString();
            lblApprovedValue.Text = applications.Count(a => a.Status == "Approved").ToString();
            lblRejectedValue.Text = applications.Count(a => a.Status == "Rejected").ToString();
            lblSubmittedValue.Text = applications
                .Count(a => a.Status == "Submitted" || a.Status == "Under Review")
                .ToString();

            lstRecent.Items.Clear();
            foreach (ScholarshipApplication app in applications.Take(6))
            {
                lstRecent.Items.Add($"{app.FullName} ({app.StudentNumber}) - {app.Display}");
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                RefreshData();
            }
        }
    }
}
