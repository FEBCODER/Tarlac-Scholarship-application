using System.ComponentModel;
using System.Drawing;

namespace scholarship_Application.Models
{
    public class ScholarshipApplication
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string StudentNumber { get; set; } = "";
        public string FullName { get; set; } = "";

        [Browsable(false)]
        public string Email { get; set; } = "";
        public string ScholarshipType { get; set; } = "";
        public decimal Gpa { get; set; }
        public decimal AnnualIncome { get; set; }
        public string Status { get; set; } = "Submitted";
        public DateTime SubmittedAt { get; set; }

        [Browsable(false)]
        public bool IsRecommended { get; set; }
        [Browsable(false)]
        public decimal RecommendedAward { get; set; }
        [Browsable(false)]
        public string RecommendationReason { get; set; } = "";
        [Browsable(false)]
        public string Remarks { get; set; } = "";
        [Browsable(false)]
        public Image? Photo { get; set; }
        [Browsable(false)]
        public string Display =>
            $"{SubmissionDate:MMM d, yyyy} - {ScholarshipType} - GWA {Gpa:0.00} - {Status}";
        [Browsable(false)]
        public DateTime SubmissionDate => SubmittedAt.Date;
    }
}
