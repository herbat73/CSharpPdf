using CSharpPdf.doc;
using CSharpPdf.page;
using System;
using Xunit;

namespace CSharpPdfTest
{
    public class CreateTextPage
    {

        [Fact]
        public void CreateSimpleDocTest()
        {
            var pdfDoc = CreateDoc();
            
            Assert.NotNull(pdfDoc);
            Assert.IsType<HPDF_Doc>(pdfDoc);

            //var page = pdfDoc.HPDF_AddPage();

            //Assert.NotNull(page);
            //Assert.IsType<HPDF_Page>(pdfDoc);
        }

        HPDF_Doc CreateDoc()
        {
           return new HPDF_Doc();
        }

        //[Fact]
        //public void PassingTest()
        //{
        //    Assert.Equal(4, Add(2, 2));
        //}

        //int Add(int x, int y)
        //{
        //    return x + y;
        //}

        //[Theory]
        //[InlineData(3)]
        //[InlineData(5)]
        //[InlineData(6)]
        //public void MyFirstTheory(int value)
        //{
        //    Assert.True(IsOdd(value));
        //}

        //bool IsOdd(int value)
        //{
        //    return value % 2 == 1;
        //}
    }
}
