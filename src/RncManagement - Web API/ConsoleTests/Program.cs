using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var importer = new RncManagement.Data.CsvImporter();
            importer.ImportarArchivo();
        }
    }
}
