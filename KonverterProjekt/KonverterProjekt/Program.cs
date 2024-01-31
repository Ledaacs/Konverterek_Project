using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonverterProjekt
{
    using System;
    using System.IO;

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

            // Ellenőrizzük, hogy a forrásfájl neve tartalmaz-e olyan kiterjesztést, ami elfogadható
            string[] elfogadottKiterjesztesek = { ".csv", ".json", ".txt", ".xml", ".xlsx" };
            bool ervenyesKiterjesztes = false;

            foreach (var kiterjesztes in elfogadottKiterjesztesek)
            {
                if (sourceFilePath.EndsWith(kiterjesztes, StringComparison.OrdinalIgnoreCase))
                {
                    ervenyesKiterjesztes = true;
                    break;
                }
            }

            if (!ervenyesKiterjesztes)
            {
                Console.WriteLine("A forrásfájl kiterjesztése nem megfelelő.");
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

            FormatConvert.ConvertCsvToXlsx(sourceFilePath, targetFilePath);

            Console.ReadLine();
        }
    }
}