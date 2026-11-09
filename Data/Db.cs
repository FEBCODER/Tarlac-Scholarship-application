using Microsoft.Data.SqlClient;

namespace scholarship_Application.Data
{
    public static class Db
    {
        private const string Server =
            @"Server=(localdb)\MSSQLLocalDB;Database=master;Trusted_Connection=True;";

        public const string DatabaseName = "TarlacScholarship";

        public static SqlConnection Open()
        {
            SqlConnection connection = new(
                $@"Server=(localdb)\MSSQLLocalDB;Database={DatabaseName};Trusted_Connection=True;");
            connection.Open();
            return connection;
        }

        public static void EnsureCreated()
        {
            using (SqlConnection master = new(Server))
            {
                master.Open();
                using SqlCommand create = new(
                    "IF DB_ID(@db) IS NULL CREATE DATABASE " + DatabaseName, master);
                create.Parameters.AddWithValue("@db", DatabaseName);
                create.ExecuteNonQuery();
            }

            using SqlConnection connection = Open();
            using SqlCommand script = new(Tables, connection);
            script.ExecuteNonQuery();

            Seed(connection);
        }

        private static void Seed(SqlConnection connection)
        {
            if (!RowsExist(connection, "dbo.Users"))
            {
                (string salt, string hash) admin = PasswordHasher.Hash("admin123");
                (string salt, string hash) student = PasswordHasher.Hash("student123");

                using SqlCommand seedUsers = new(
                    """
                    INSERT INTO dbo.Users (Username, PasswordHash, Salt, FullName, StudentNumber, IsAdmin)
                    VALUES (@u1, @p1, @s1, N'City Scholarship Office Admin', NULL, 1),
                           (@u2, @p2, @s2, N'Ana Marisol Reyes', N'2023-0001', 0)
                    """, connection);
                seedUsers.Parameters.AddWithValue("@u1", "admin");
                seedUsers.Parameters.AddWithValue("@p1", admin.hash);
                seedUsers.Parameters.AddWithValue("@s1", admin.salt);
                seedUsers.Parameters.AddWithValue("@u2", "ana");
                seedUsers.Parameters.AddWithValue("@p2", student.hash);
                seedUsers.Parameters.AddWithValue("@s2", student.salt);
                seedUsers.ExecuteNonQuery();
            }

            if (!RowsExist(connection, "dbo.Applications"))
            {
                using SqlCommand seedApps = new(
                    """
                    INSERT INTO dbo.Applications
                        (StudentNumber, FullName, Email, ScholarshipType, Gpa, AnnualIncome,
                         Status, SubmittedAt, Remarks, IsRecommended, RecommendedAward, RecommendationReason)
                    VALUES
                        (N'2023-0001', N'Ana Marisol Reyes', N'ana.reyes@tarlac.gov.ph',
                         N'Merit', 3.80, 350000, N'Under Review', DATEADD(day, -2, SYSUTCDATETIME()),
                         NULL, 1, 50000, N'Meets the merit requirement (GWA >= 3.50).'),
                        (N'2023-0002', N'Jose Miguel Cruz', N'jose.cruz@tarlac.gov.ph',
                         N'Need-based', 3.10, 180000, N'Submitted', DATEADD(day, -1, SYSUTCDATETIME()),
                         NULL, 1, 80000, N'Household income is within the need-based threshold.'),
                        (N'2023-0003', N'Karla Santos', N'karla.santos@tarlac.gov.ph',
                         N'General', 2.10, 700000, N'Rejected', DATEADD(day, -3, SYSUTCDATETIME()),
                         N'Below program requirements.', 0, 0, N'General requires a GWA of at least 2.50.');
                    """, connection);
                seedApps.ExecuteNonQuery();
            }
        }

        private static bool RowsExist(SqlConnection connection, string table)
        {
            using SqlCommand command = new($"SELECT COUNT(*) FROM {table}", connection);
            return (int)command.ExecuteScalar()! > 0;
        }

        private const string Tables =
            """
            IF OBJECT_ID('dbo.Users', 'U') IS NULL
                CREATE TABLE dbo.Users
                (
                    Id            int IDENTITY PRIMARY KEY,
                    Username      nvarchar(50)  NOT NULL UNIQUE,
                    PasswordHash  nvarchar(256) NOT NULL,
                    Salt          nvarchar(128) NOT NULL,
                    FullName      nvarchar(120) NOT NULL,
                    StudentNumber nvarchar(20)  NULL,
                    IsAdmin       bit NOT NULL DEFAULT 0
                );

            IF OBJECT_ID('dbo.Applications', 'U') IS NULL
                CREATE TABLE dbo.Applications
                (
                    Id                  int IDENTITY PRIMARY KEY,
                    StudentNumber       nvarchar(20)  NOT NULL,
                    FullName            nvarchar(120) NOT NULL,
                    Email               nvarchar(160) NOT NULL,
                    ScholarshipType     nvarchar(50)  NOT NULL,
                    Gpa                 decimal(4,2)  NOT NULL,
                    AnnualIncome        decimal(18,2) NOT NULL,
                    Status              nvarchar(20)  NOT NULL DEFAULT N'Submitted',
                    SubmittedAt         datetime2     NOT NULL DEFAULT SYSUTCDATETIME(),
                    Remarks             nvarchar(400) NULL,
                    IsRecommended       bit NOT NULL DEFAULT 0,
                    RecommendedAward    decimal(18,2) NOT NULL DEFAULT 0,
                    RecommendationReason nvarchar(200) NOT NULL DEFAULT N'',
                    Photo               varbinary(max) NULL
                );
            """;
    }
}
