using Tyuiu.ShakirovaGM.Sprint6.Task0.V2.Lib;
namespace Tyuiu.ShakirovaGM.Sprint6.Task0.V2
    
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
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}