using System.Windows.Forms;
using scholarship_Application.Models;

namespace scholarship_Application.Controls
{
    public partial class StudentHomeControl : UserControl, IRefreshable
    {
        public StudentHomeControl()
        {
            InitializeComponent();

            lstPrograms.Items.AddRange(new object[]
            {
                "Merit - GWA >= 3.50 - up to PHP 50,000",
                "Need-based - income <= PHP 400,000/yr - up to PHP 80,000",
                "General - GWA >= 2.50 and income <= PHP 600,000/yr - PHP 20,000",
            });

            lstAnnouncements.Items.AddRange(new object[]
            {
                "Tarlac City applications for SY 2026-2027 are open until March 31, 2027.",
                "Submit all required documents before the deadline.",
                "Keep your email and contact number updated.",
                "Status updates appear under My Applications after review.",
            });
        }

        public void RefreshData()
        {
            lblWelcome.Text = "Welcome, Ana Marisol Reyes!";

            var mine = SampleData.Applications
                .Where(a => a.StudentNumber == SampleData.DemoStudentNumber)
                .ToList();
            lblSubmittedValue.Text = mine.Count(a => a.Status == "Submitted" || a.Status == "Under Review").ToString();
            lblApprovedValue.Text = mine.Count(a => a.Status == "Approved").ToString();
            lblRejectedValue.Text = mine.Count(a => a.Status == "Rejected").ToString();
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
