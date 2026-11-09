namespace scholarship_Application
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                scholarship_Application.Data.Db.EnsureCreated();
            }
            catch
            {
                MessageBox.Show(
                    "Could not connect to SQL Server LocalDB ((localdb)\\MSSQLLocalDB).\n" +
                    "Make sure it is installed (Visual Studio usually installs it), then try again.",
                    "Database unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.Run(new scholarship_Application.Forms.LoginForm());
        }
    }
}
