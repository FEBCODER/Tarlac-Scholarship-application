using System.Windows.Forms;
using scholarship_Application.Models;

namespace scholarship_Application.Controls
{
    public partial class MyApplicationsControl : UserControl, IRefreshable
    {
        public MyApplicationsControl()
        {
            InitializeComponent();
            Ui.Style(grid);
        }

        public void RefreshData()
        {
            List<ScholarshipApplication> mine = SampleData.Applications
                .Where(a => a.StudentNumber == SampleData.DemoStudentNumber)
                .OrderByDescending(a => a.SubmittedAt)
                .ToList();

            grid.DataSource = mine;
            Ui.TuneColumns(grid);
            lblSummary.Text = $"{mine.Count} application(s) shown - statuses update in this window only.";
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
