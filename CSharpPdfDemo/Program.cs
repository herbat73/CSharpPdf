using System;
using CSharpPdf.Doc;
using CSharpPdf.Page;

namespace CSharpPdfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello CSharpPDF...");
            var pdfDoc = CreateDoc();

            Console.ReadKey();
        }

        static HPDF_Doc CreateDoc()
        {
            return new HPDF_Doc();
        }
    }
}
