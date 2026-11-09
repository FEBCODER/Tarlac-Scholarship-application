using System.Windows.Forms;
using scholarship_Application.Data;
using scholarship_Application.Forms;
using scholarship_Application.Models;

namespace scholarship_Application.Controls
{
    public partial class AdminApplicationsControl : UserControl, IRefreshable
    {
        public AdminApplicationsControl()
        {
            InitializeComponent();

            Ui.Style(grid);
            cboFilter.SelectedIndex = 0;
        }

        public void RefreshData()
        {
            List<ScholarshipApplication> source =
                AppRepository.List(null, cboFilter.SelectedItem?.ToString() ?? "All");

            grid.DataSource = source;
            Ui.TuneColumns(grid);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                RefreshData();
            }
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void grid_DataBindingComplete(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void ShowDetail()
        {
            if (grid.CurrentRow?.DataBoundItem is not ScholarshipApplication app)
            {
                lblDetail.Text = "Select an application.";
                picAppPhoto.Visible = false;
                picAppPhoto.Image = null;
                return;
            }

            picAppPhoto.Visible = app.Photo is not null;
            picAppPhoto.Image = app.Photo;

            lblDetail.Text =
                $"{app.FullName} ({app.StudentNumber})\n" +
                $"Program: {app.ScholarshipType}\n" +
                $"GWA: {app.Gpa:0.00}   |   Household income: PHP {app.AnnualIncome:N0} / year\n" +
                $"Email: {app.Email}\n" +
                $"Status: {app.Status}\n" +
                $"Recommendation: {(app.IsRecommended ? $"eligible, ~PHP {app.RecommendedAward:N0}" : "not eligible")}\n" +
                $"Reason: {app.RecommendationReason}\n" +
                $"Remarks: {(string.IsNullOrWhiteSpace(app.Remarks) ? "-" : app.Remarks)}";
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            RecordDecision("Approved");
        }

        private void btnUnderReview_Click(object sender, EventArgs e)
        {
            RecordDecision("Under Review");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            RecordDecision("Rejected");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using var form = new AdminApplicationForm();
            if (form.ShowDialog(FindForm()) != DialogResult.OK || form.NewApplication is null)
            {
                return;
            }

            AppRepository.Add(form.NewApplication);
            cboFilter.SelectedIndex = 0;
            RefreshData();
        }

        private void RecordDecision(string decision)
        {
            if (grid.CurrentRow?.DataBoundItem is not ScholarshipApplication app)
            {
                MessageBox.Show("Select an application first.",
                    "No application selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            app.Remarks = txtRemarks.Text.Trim();
            AppRepository.SetStatus(app.Id, decision, app.Remarks);

            lstHistory.Items.Insert(0,
                $"{DateTime.Now:MMM d HH:mm} {decision} - {app.FullName} ({app.StudentNumber})");

            txtRemarks.Clear();
            RefreshData();
        }
    }
}
