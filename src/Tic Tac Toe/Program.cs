namespace Tic_Tac_Toe_;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // Set dark mode if the system is in dark mode
        // This feature is experimental in .NET 9: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/whats-new/net90#dark-mode
        Application.SetColorMode(SystemColorMode.System);

        Application.Run(new Form1());
    }
}
