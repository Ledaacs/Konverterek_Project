using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonverterProjekt
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string sourceFilePath = args[0];
            string targetFilePath = args[1];
            string jsonResult = FormatConvert.ConvertCsvToJson(sourceFilePath, targetFilePath);

            if (jsonResult != null)
            {
                Console.WriteLine("CSV to JSON konverzió eredménye:");
                Console.WriteLine(jsonResult);
            }

            Console.ReadLine();
        }
    }
}
