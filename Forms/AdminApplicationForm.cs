using scholarship_Application.Models;

namespace scholarship_Application.Forms
{
    public partial class AdminApplicationForm : Form
    {
        public AdminApplicationForm()
        {
            InitializeComponent();
            cboProgram.SelectedIndex = 0;
            txtEmail.Focus();
        }

        public ScholarshipApplication? NewApplication { get; private set; }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (ofdPhoto.ShowDialog(this) != DialogResult.OK)
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
                MessageBox.Show(this, "That file is not a valid image.",
                    "Invalid picture", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NewApplication = new ScholarshipApplication
            {
                FullName = string.IsNullOrWhiteSpace(txtFullName.Text)
                    ? "Unnamed applicant"
                    : txtFullName.Text.Trim(),
                StudentNumber = string.IsNullOrWhiteSpace(txtStudentNumber.Text)
                    ? $"2023-{Random.Shared.Next(100, 9999):0000}"
                    : txtStudentNumber.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(txtEmail.Text)
                    ? "not.provided@tarlac.gov.ph"
                    : txtEmail.Text.Trim(),
                ScholarshipType = cboProgram.SelectedItem?.ToString() ?? "Merit",
                Gpa = nudGwa.Value,
                AnnualIncome = nudIncome.Value,
                Status = "Submitted",
                Remarks = "",
                SubmittedAt = DateTime.Now,
                Photo = picPhoto.Image is null ? null : new Bitmap(picPhoto.Image),
            };
        }
    }
}
