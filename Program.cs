namespace scholarship_Application
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new scholarship_Application.Forms.LoginForm());
        }
    }
}
