using System;
using System.Collections.Generic;

namespace ISP1
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

            IReportWriter docRepWriter = new ReportWriterDoc();
            docRepWriter.ReportName = "Document Report";
            docRepWriter.SetupReportFields();
            docRepWriter.SetReportRecordSortOrder();
            docRepWriter.ShowReportHeaders(true);
            docRepWriter.ChangeReportNumericFormat();
            docRepWriter.SetDocAsReadOnly();
            docRepWriter.RunDocMarco();
            docRepWriter.SetDocLineSpacing();
            // docRepWriter.LockSpreadsheeArea();
            // docRepWriter.SetSpreadsheetDataSource();
            // docRepWriter.SetPdfCompression();
            // docRepWriter.SetPdfEncryption();

            IReportWriter spreadSheetRepWriter = new ReportWriterSpreadsheet();
            spreadSheetRepWriter.ReportName = "Spreadsheet Report";
            spreadSheetRepWriter.SetupReportFields();
            spreadSheetRepWriter.SetReportRecordSortOrder();
            spreadSheetRepWriter.ShowReportHeaders(true);
            spreadSheetRepWriter.ChangeReportNumericFormat();
            // spreadSheetRepWriter.SetDocAsReadOnly();
            // spreadSheetRepWriter.RunDocMarco();
            // spreadSheetRepWriter.SetDocLineSpacing();
            spreadSheetRepWriter.LockSpreadsheetArea();
            spreadSheetRepWriter.SetSpreadsheetDataSource();
            // spreadSheetRepWriter.SetPdfCompression();
            // spreadSheetRepWriter.SetPdfEncryption();

            IReportWriter pdfRepWriter = new ReportWriterPdf();
            pdfRepWriter.ReportName = "Pdf Report";
            pdfRepWriter.SetupReportFields();
            pdfRepWriter.SetReportRecordSortOrder();
            pdfRepWriter.ShowReportHeaders(true);
            pdfRepWriter.ChangeReportNumericFormat();
            // pdfRepWriter.SetDocAsReadOnly();
            // pdfRepWriter.RunDocMarco();
            // pdfRepWriter.SetDocLineSpacing();
            // pdfRepWriter.LockSpreadsheeArea();
            // pdfRepWriter.SetSpreadsheetDataSource();
            pdfRepWriter.SetPdfCompression();
            pdfRepWriter.SetPdfEncryption();

            List<IReportWriter> reportWriterList = new List<IReportWriter>
            {
                docRepWriter, spreadSheetRepWriter, pdfRepWriter
            };
            
            reportWriterList.ForEach(reportWriter => reportWriter.GenerateTimeEntryReport(ftEmpJohnDoe));

            // Problem: When adding a new report type, you are force to implement it on all existing codes.  Apply ISP on IReportWriter.cs
        }
    }
}
