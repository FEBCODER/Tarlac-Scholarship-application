using System.Windows.Forms;
using scholarship_Application.Data;
using scholarship_Application.Models;

namespace scholarship_Application.Controls
{
    public partial class ApplyControl : UserControl, IRefreshable
    {
        public ApplyControl()
        {
            InitializeComponent();

            cboProgram.Items.AddRange(new object[] { "Merit", "Need-based", "General" });

            txtFullName.Text = AppSession.FullName;
            txtStudentNumber.Text = AppSession.StudentNumber;
        }

        private void cboProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHint.Text = cboProgram.SelectedIndex switch
            {
                0 => "Merit - GWA of at least 3.50. Award up to PHP 50,000.",
                1 => "Need-based - household income of at most PHP 400,000 per year. Award up to PHP 80,000.",
                2 => "General - GWA of at least 2.50 and income of at most PHP 600,000 per year. Award PHP 20,000.",
                _ => "Select a scholarship program to see its eligibility rule.",
            };
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (ofdPhoto.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                picPhoto.Image?.Dispose();
                picPhoto.Image = Image.FromFile(ofdPhoto.FileName);
            }
            catch
            {
                MessageBox.Show("That file is not a valid image.",
                    "Invalid picture", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var application = new ScholarshipApplication
            {
                StudentNumber = AppSession.StudentNumber,
                FullName = AppSession.FullName,
                Email = string.IsNullOrWhiteSpace(txtEmail.Text)
                    ? "ana.reyes@tarlac.gov.ph"
                    : txtEmail.Text.Trim(),
                ScholarshipType = cboProgram.SelectedItem?.ToString() ?? "Merit",
                Gpa = nudGwa.Value,
                AnnualIncome = nudIncome.Value,
                Status = "Submitted",
                Remarks = "",
                SubmittedAt = DateTime.Now,
                Photo = picPhoto.Image is null ? null : new Bitmap(picPhoto.Image),
            };

            AppRepository.Add(application);
            RefreshData();

            MessageBox.Show(
                "Thank you! Your application has been submitted for review.\n" +
                "The scholarship office will update your status.",
                "Application submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtEmail.Clear();
            cboProgram.SelectedIndex = -1;
            nudGwa.Value = nudGwa.Minimum;
            nudIncome.Value = 0;
            lblHint.Text = "Select a scholarship program to see its eligibility rule.";
            picPhoto.Image?.Dispose();
            picPhoto.Image = null;
            txtEmail.Focus();
        }

        public void RefreshData()
        {
            List<ScholarshipApplication> mine =
                AppRepository.List(AppSession.StudentNumber, "All");

            lstMine.Items.Clear();
            foreach (ScholarshipApplication app in mine)
            {
                lstMine.Items.Add(app.Display);
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

