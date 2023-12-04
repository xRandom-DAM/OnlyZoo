using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.util
{
    internal class ErrorManager
    {
        public static void Register(Exception ex)
        {
            ShowToUser(ex);
            Save(ex);
        }
        public static void ShowToUser(Exception ex)
        {
            string errorMessage = $"Se produjo un error:\n\n{ex.Message}";
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Save(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter(Constants.ErrorLogFile, true))
            {
                writer.WriteLine($"Fecha y hora: {DateTime.Now}");
                // Escribir la información de la excepción
                writer.WriteLine($"Mensaje de error: {ex.Message}");
                writer.WriteLine($"Tipo de excepción: {ex.GetType().FullName}");
                writer.WriteLine($"Stack Trace: {ex.StackTrace}");
                writer.WriteLine(new string('-', 50));
            }
        }
    }
}
