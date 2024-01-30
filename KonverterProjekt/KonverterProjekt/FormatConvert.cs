﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;



namespace KonverterProjekt
{
    internal static class FormatConvert
    {
        public static string ConvertCsvToJson(string csvFilePath, string targetFilePath)
        {
            try
            {
                // Olvassuk be a CSV fájlt
                using (var reader = new StreamReader(csvFilePath))
                using (var csv = new CsvReader(new CsvParser(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" })))
                {
                    // Használjuk a CsvHelper-t a CSV beolvasásához
                    var records = csv.GetRecords<dynamic>();

                    // Konvertáljuk a rekordokat JSON formátumba
                    string jsonResult = JsonConvert.SerializeObject(records, Formatting.Indented);
                    File.WriteAllText(targetFilePath, jsonResult);
                    return jsonResult;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt a konverzió során: {ex.Message}");
                return null;
            }
        }

        

//        internal static void ConvertExcelToCsv(string excelInputFilePath, string csvOutputFilePath)
//        {
//            {
//                try
//                {
//                    using (var reader = new StreamReader(csvFilePath))
//                    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" }))
//                    {
//                        using (var package = new ExcelPackage())
//                        {
//                            var worksheet = package.Workbook.Worksheets.Add("Sheet1");
//                            var records = csv.GetRecords<dynamic>();
//                            int row = 1;

//                            foreach (var record in records)
//                            {
//                                int column = 1;
//                                foreach (var property in record)
//                                {
//                                    worksheet.Cells[row, column].Value = property.Value;
//                                    column++;
//                                }
//                                row++;
//                            }

//                            package.SaveAs(new FileInfo(excelFilePath));
//                        }
//                    }

//                    Console.WriteLine($"CSV to Excel konverzió kész. Az eredményt megtalálod itt: {excelFilePath}");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hiba történt a konverzió során: {ex.Message}");
//                }
//            }
//        }
   }
}
