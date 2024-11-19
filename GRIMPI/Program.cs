using Sistema.View.AppCliente;
using Sistema.View.AppCliente.HomeApp;
using Sistema.View.Gerencia;
using Sistema.View.Home;
using Sistema.View.View.Gerencia;

namespace GRIMPI
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
            Application.Run(new login());
        }
    }
}