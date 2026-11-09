using System.Windows.Forms;
using scholarship_Application.Data;
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
            List<ScholarshipApplication> mine =
                AppRepository.List(AppSession.StudentNumber, "All");

            grid.DataSource = mine;
            Ui.TuneColumns(grid);
            lblSummary.Text = $"{mine.Count} application(s) shown.";
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
