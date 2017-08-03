using System;
using System.IO.Packaging;
using System.Windows;
using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System.Reflection;

namespace TestOpenXML
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string fileName = @"../../task.xlsx";
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(fileName, true))
			{
				Console.WriteLine();
				Console.ReadKey();
			}


        }
    }
}
