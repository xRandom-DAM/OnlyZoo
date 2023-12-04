using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.util
{
    public class FileManager
    {
        public static bool CreateFile(string fullPath)
        {
            try
            {
                // Dividir el path en directorios y nombre del archivo
                string[] partes = fullPath.Split('/');
                if (partes[partes.Length - 1].Trim().Length < 1) return false;
                if (partes.Length > 1)
                {
                    string[] directorios = new string[partes.Length - 1];
                    Array.Copy(partes, directorios, directorios.Length);
                    string nombreArchivo = partes[partes.Length - 1];

                    string rutaDirectorios = Path.Combine(directorios);

                    // Verificar y crear cada directorio en la ruta
                    if (!Directory.Exists(rutaDirectorios))
                    {
                        Directory.CreateDirectory(rutaDirectorios);
                        Console.WriteLine($"Directorio '{rutaDirectorios}' creado con éxito.");
                    }

                }
                
                using (FileStream fs = File.Create(fullPath))
                {
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                ErrorManager.Register(ex);
                return false;
            }
        }

        public static bool CreateFileIfNotExists(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                return CreateFile(path);
            }
            return true;
        }

    }

}
