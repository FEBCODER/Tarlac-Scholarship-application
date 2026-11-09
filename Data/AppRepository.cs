using Microsoft.Data.SqlClient;
using scholarship_Application.Models;

namespace scholarship_Application.Data
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string FullName { get; set; } = "";
        public string StudentNumber { get; set; } = "";
        public bool IsAdmin { get; set; }
    }

    public static class AppRepository
    {
        public static AppUser? SignIn(string username, string password)
        {
            using SqlConnection connection = Db.Open();

            using SqlCommand command = new(
                """
                SELECT Id, Username, PasswordHash, Salt, FullName,
                       ISNULL(StudentNumber, '') AS StudentNumber, IsAdmin
                FROM dbo.Users
                WHERE Username = @username
                """, connection);
            command.Parameters.AddWithValue("@username", username.Trim());

            using SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read() || !PasswordHasher.Verify(password, reader.GetString(3), reader.GetString(2)))
            {
                return null;
            }

            return new AppUser
            {
                Id = reader.GetInt32(0),
                Username = reader.GetString(1),
                FullName = reader.GetString(4),
                StudentNumber = reader.GetString(5),
                IsAdmin = reader.GetBoolean(6),
            };
        }

        public static List<ScholarshipApplication> List(string? studentNumber, string status)
        {
            List<ScholarshipApplication> rows = [];

            using SqlConnection connection = Db.Open();

            string where = "WHERE (@student = '' OR StudentNumber = @student)" +
                           " AND (@status = N'All' OR Status = @status)";
            using SqlCommand command = new($"SELECT * FROM dbo.Applications {where}", connection);
            command.Parameters.AddWithValue("@student", studentNumber ?? "");
            command.Parameters.AddWithValue("@status", status ?? "All");

            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                rows.Add(new ScholarshipApplication
                {
                    Id = reader.GetInt32(0),
                    StudentNumber = reader.GetString(1),
                    FullName = reader.GetString(2),
                    Email = reader.GetString(3),
                    ScholarshipType = reader.GetString(4),
                    Gpa = reader.GetDecimal(5),
                    AnnualIncome = reader.GetDecimal(6),
                    Status = reader.GetString(7),
                    SubmittedAt = reader.GetDateTime(8),
                    Remarks = reader.IsDBNull(9) ? "" : reader.GetString(9),
                    IsRecommended = reader.GetBoolean(10),
                    RecommendedAward = reader.GetDecimal(11),
                    RecommendationReason = reader.GetString(12),
                    Photo = ImageStore.ToImage(reader.IsDBNull(13) ? null : (byte[])reader[13]),
                });
            }

            return rows.OrderByDescending(a => a.SubmittedAt).ToList();
        }

        public static void Add(ScholarshipApplication application)
        {
            using SqlConnection connection = Db.Open();

            using SqlCommand command = new(
                """
                INSERT INTO dbo.Applications
                    (StudentNumber, FullName, Email, ScholarshipType, Gpa, AnnualIncome,
                     Status, SubmittedAt, Remarks, IsRecommended, RecommendedAward, RecommendationReason, Photo)
                VALUES
                    (@student, @name, @email, @type, @gpa, @income,
                     @status, @submitted, @remarks, @recommended, @award, @reason, @photo)
                """, connection);
            Fill(command, application);
            command.ExecuteNonQuery();
        }

        public static void SetStatus(int id, string status, string remarks)
        {
            using SqlConnection connection = Db.Open();

            using SqlCommand command = new(
                """
                UPDATE dbo.Applications
                SET Status = @status, Remarks = @remarks
                WHERE Id = @id
                """, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@remarks", (object?)remarks ?? DBNull.Value);
            command.ExecuteNonQuery();
        }

        private static void Fill(SqlCommand command, ScholarshipApplication application)
        {
            command.Parameters.AddWithValue("@student", application.StudentNumber);
            command.Parameters.AddWithValue("@name", application.FullName);
            command.Parameters.AddWithValue("@email", application.Email);
            command.Parameters.AddWithValue("@type", application.ScholarshipType);
            command.Parameters.AddWithValue("@gpa", application.Gpa);
            command.Parameters.AddWithValue("@income", application.AnnualIncome);
            command.Parameters.AddWithValue("@status", application.Status);
            command.Parameters.AddWithValue("@submitted", application.SubmittedAt);
            command.Parameters.AddWithValue("@remarks",
                string.IsNullOrWhiteSpace(application.Remarks) ? DBNull.Value : application.Remarks);
            command.Parameters.AddWithValue("@recommended", application.IsRecommended);
            command.Parameters.AddWithValue("@award", application.RecommendedAward);
            command.Parameters.AddWithValue("@reason", application.RecommendationReason);
            command.Parameters.AddWithValue("@photo",
                (object?)ImageStore.ToBytes(application.Photo) ?? DBNull.Value);
        }
    }
}
