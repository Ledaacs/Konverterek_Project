using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonverterProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Hiányzó argumentumok. Kérem adja meg a forrás és a cél fájl elérési útját.");
                Console.ReadLine();
                return;
            }

            string sourceFilePath = args[0];
            string targetFilePath = args[1];

            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("A megadott forrásfájl nem létezik: " + sourceFilePath);
                Console.ReadLine();
                return;
            }

            //.csv cél .json
            string jsonResult = FormatConvert.ConvertCsvToJson(sourceFilePath, targetFilePath);

            if (jsonResult != null)
            {
                Console.WriteLine("CSV to JSON konverzió eredménye:");
                Console.WriteLine(jsonResult);
            }

            Console.ReadLine();
        }
    }



    //asd
    //static void ConvertExcelToCsv(string[] args)
    //{
    //    // Példa: CSV to Excel konverzió
    //    string csvFilePath = "input.csv";
    //    string excelFilePath = "output.xlsx";
    //    FormatConvert.ConvertCsvToExcel(csvFilePath, excelFilePath);

    //    // Példa: Excel to CSV konverzió
    //    string excelInputFilePath = "input.xlsx";
    //    string csvOutputFilePath = "output.csv";
    //    FormatConvert.ConvertExcelToCsv(excelInputFilePath, csvOutputFilePath);
    //}

}
