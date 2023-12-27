namespace GM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // console.writeline hello mouad;

<<<<<<< HEAD
            // hello from ilyess
=======
            // hello from ilyiss
>>>>>>> 7e5c6ec48127b989afe7b1fda5361365df9592bf

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            ApplicationConfiguration.Initialize();
            Application.Run(new Login_Form());
        }
    }
}