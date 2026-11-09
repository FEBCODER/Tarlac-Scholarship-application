namespace scholarship_Application.Data
{
    public static class AppSession
    {
        public static string Username { get; set; } = "";
        public static string FullName { get; set; } = "";
        public static string StudentNumber { get; set; } = "";
        public static bool IsAdmin { get; set; }
    }
}
