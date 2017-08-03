using DocumentFormat.OpenXml.Packaging;
using System;

namespace TestOpenXML
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open("task.xlsx", true))
			{
                Console.WriteLine("Success!");
			}
        }
    }
}
