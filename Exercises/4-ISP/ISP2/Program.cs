using System;
using System.Collections.Generic;

namespace ISP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonnelWithBenefits ftEmpJohnDoe = new FullTimePersonnel
            {
                Id = 1,
                Name = "John Doe",
                Department = "Acme Department",
                TaxDeductibles = 16.4D,
                LoanDeductibles = 27.3D,
                MedicalDeductibles = 25.0D,
                PaySchedule = DateTime.Now,
                AnnualSalary = 50000.00D
            };

            ReportWriterDoc docRepWriter = new ReportWriterDoc();
            docRepWriter.ReportName = "Document Report";
            docRepWriter.SetupReportFields();
            docRepWriter.SetReportRecordSortOrder();
            docRepWriter.ShowReportHeaders(true);
            docRepWriter.ChangeReportNumericFormat();
            docRepWriter.GenerateTimeEntryReport(ftEmpJohnDoe);
            docRepWriter.SetDocAsReadOnly();
            docRepWriter.RunDocMarco();
            docRepWriter.SetDocLineSpacing();

            ReportWriterSpreadSheet spreadSheetRepWriter = new ReportWriterSpreadSheet();
            spreadSheetRepWriter.ReportName = "Spreadsheet Report";
            spreadSheetRepWriter.SetupReportFields();
            spreadSheetRepWriter.SetReportRecordSortOrder();
            spreadSheetRepWriter.ShowReportHeaders(true);
            spreadSheetRepWriter.ChangeReportNumericFormat();
            spreadSheetRepWriter.GenerateTimeEntryReport(ftEmpJohnDoe);
            spreadSheetRepWriter.LockSpreadsheetArea();
            spreadSheetRepWriter.SetSpreadsheetDataSource();

            ReportWriterPdf pdfRepWriter = new ReportWriterPdf();
            pdfRepWriter.ReportName = "Pdf Report";
            pdfRepWriter.SetupReportFields();
            pdfRepWriter.SetReportRecordSortOrder();
            pdfRepWriter.ShowReportHeaders(true);
            pdfRepWriter.ChangeReportNumericFormat();
            pdfRepWriter.GenerateTimeEntryReport(ftEmpJohnDoe);
            pdfRepWriter.SetPdfCompression();
            pdfRepWriter.SetPdfEncryption();
            
            List<IReportWriter> reportWriterList = new List<IReportWriter>
            {
                docRepWriter, spreadSheetRepWriter, pdfRepWriter
            };
            
            Console.WriteLine("\nReports ready.");
            reportWriterList.ForEach(reportWriter => reportWriter.GenerateTimeEntryReport(ftEmpJohnDoe));
        }
    }
}
