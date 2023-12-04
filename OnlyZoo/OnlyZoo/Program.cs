using MySql.Data.MySqlClient;
using OnlyZoo.development.tests;
using OnlyZoo.drivers;

namespace OnlyZoo
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
            //ApplicationConfiguration.Initialize();
            //Tests.Init();
            Application.Run(new Mascotas());

        }

    }
}