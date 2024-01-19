using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("Valami.txt"));

            Console.ReadLine();
        }
    }
}
