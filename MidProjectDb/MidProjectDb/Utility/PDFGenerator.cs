using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

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

    public void ExportDataTableToPDF(string reportName, string datasetName, DataTable dataTable)
    {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save PDF Report";
            saveFileDialog.FileName = reportName.Replace(" ", "_") + ".pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LocalReport localReport = new LocalReport();
                    localReport.ReportEmbeddedResource = $"MidProjectDb.BL.Reports.{reportName}.rdlc";
                    localReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource(datasetName, dataTable);
                    localReport.DataSources.Add(rds);
                    localReport.Refresh();
                    string deviceInfo = @"
                    <DeviceInfo>
                        <OutputFormat>PDF</OutputFormat>
                        <PageWidth>8.5in</PageWidth>
                        <PageHeight>11in</PageHeight>
                        <MarginTop>0.5in</MarginTop>
                        <MarginLeft>0.5in</MarginLeft>
                        <MarginRight>0.5in</MarginRight>
                        <MarginBottom>0.5in</MarginBottom>
                    </DeviceInfo>";
                    byte[] bytes = localReport.Render("PDF", deviceInfo);
                    File.WriteAllBytes(saveFileDialog.FileName, bytes);
                    MessageBox.Show("PDF saved successfully at: " + saveFileDialog.FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}

