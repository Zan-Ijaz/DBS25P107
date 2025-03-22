using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

public class ReportGenerator
{
    private static ReportGenerator _instance;
    private ReportGenerator() { }

    public static ReportGenerator Instance
    {
        get
        {
            if (_instance == null) _instance = new ReportGenerator();
            return _instance;
        }
    }

    public void ExportDataTableToPDF(DataTable dt, string title)
    {
        using (SaveFileDialog sfd = new SaveFileDialog())
        {
            sfd.Filter = "PDF Files (*.pdf)|*.pdf";
            sfd.Title = "Save PDF Report";
            sfd.FileName = title.Replace(" ", "_") + ".pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        Document doc = new Document(PageSize.A4, 40, 40, 70, 70); // Increased top & bottom margins
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        writer.PageEvent = new PDFHeaderFooter();

                        doc.Open();

                        // Title
                        Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                        Paragraph titlePara = new Paragraph(title, titleFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        doc.Add(titlePara);
                        doc.Add(new Paragraph("\n"));

                        // Create table
                        PdfPTable table = new PdfPTable(dt.Columns.Count);
                        table.WidthPercentage = 100;

                        // Add column headers
                        foreach (DataColumn column in dt.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                            {
                                BackgroundColor = BaseColor.LIGHT_GRAY,
                                HorizontalAlignment = Element.ALIGN_CENTER
                            };
                            table.AddCell(cell);
                        }

                        // Add data rows
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (var item in row.ItemArray)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10)))
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER
                                };
                                table.AddCell(cell);
                            }
                        }

                        doc.Add(table);
                        doc.Close();
                    }

                    MessageBox.Show("PDF saved successfully at: " + sfd.FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    // Nested class for Header & Footer with correct line spacing
    private class PDFHeaderFooter : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            PdfContentByte cb = writer.DirectContent;
            float pageWidth = document.PageSize.Width;
            float leftMargin = document.LeftMargin;
            float rightMargin = document.RightMargin;
            float headerY = document.PageSize.Height - 30;
            PdfPTable headerTable = new PdfPTable(1)
            {
                TotalWidth = pageWidth - leftMargin - rightMargin
            };
            PdfPCell headerCell = new PdfPCell(new Phrase("Faculty Workload and Resource Allocation System", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = Rectangle.NO_BORDER,
                PaddingTop = 5
            };
            headerTable.AddCell(headerCell);
            headerTable.WriteSelectedRows(0, -1, leftMargin, headerY, cb);
            cb.MoveTo(leftMargin, headerY - 25);
            cb.LineTo(pageWidth - rightMargin, headerY - 25);
            cb.Stroke();
            float footerY = document.BottomMargin - 20;
            cb.MoveTo(leftMargin, footerY - 10);
            cb.LineTo(pageWidth - rightMargin, footerY - 10);
            cb.Stroke();
            PdfPTable footerTable = new PdfPTable(1)
            {
                TotalWidth = pageWidth - leftMargin - rightMargin
            };
            PdfPCell footerCell = new PdfPCell(new Phrase("Page " + writer.PageNumber, FontFactory.GetFont(FontFactory.HELVETICA, 10)))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = Rectangle.NO_BORDER,
                PaddingBottom = 5
            };
            footerTable.AddCell(footerCell);
            footerTable.WriteSelectedRows(0, -1, leftMargin, footerY + 25, cb);

        }
    }
}
