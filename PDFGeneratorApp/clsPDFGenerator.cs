using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using CardsAppBusinessLayer;
using CodeGenerator;
using System;

namespace PDFGeneratorApp
{

    public class clsPDFGenerator
    {
        public static void CreatePdfWithObject(string FilePath, clsCard Card)
        {

            using (PdfWriter Writer = new PdfWriter(FilePath))
            using (PdfDocument PDF = new PdfDocument(Writer))
            {
                Document NewDocument = new Document(PDF);

                NewDocument.Add(new Paragraph("Mutah Cards Application\n\n"));

                NewDocument.Add(new Paragraph("Card Information:\n"));
                NewDocument.Add(new Paragraph("Card Code: " + clsCode.FormatCode(Card.CardCode)));
                NewDocument.Add(new Paragraph("Card Type: " + Card.CardType.CardTypeValue.ToString()));
                NewDocument.Add(new Paragraph("Date: " + DateTime.Now.ToString()));

                NewDocument.Close();

            }

        }

    }

}
