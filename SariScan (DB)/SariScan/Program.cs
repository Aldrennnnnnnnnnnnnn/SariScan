namespace SariScan;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Show any unexpected error in a message box instead of silently closing.
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        Application.ThreadException += (s, e) =>
            MessageBox.Show(e.Exception.ToString(), "SariScan error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            MessageBox.Show(e.ExceptionObject.ToString(), "SariScan error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        ApplicationConfiguration.Initialize();

        try
        {
            Database.Initialize();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "SariScan could not connect to SQL Server.\n\n" + ex.Message +
                "\n\nCheck the connection string in connection.txt (see README.md > Database setup).",
                "SariScan - database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Application.Run(new LoginForm());
    }
}
