using OnlyZoo.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.development.tests
{
    internal class Tests
    {
        public static void Init()
        {
            Test("Prueba de create", TestConnection.Create(), false);
            Test("Prueba de insert", TestConnection.Insert(), true);
            Test("Prueba de select", TestConnection.Select(), true);
        }
        private static void Test(string name, bool result, bool append)
        {
            using (StreamWriter writer = new StreamWriter(Constants.TestLogFile, append))
            {
                writer.WriteLine($"{(result ? "PASS" : "FAIL")} => {name}");
            }
        }
    }
}
