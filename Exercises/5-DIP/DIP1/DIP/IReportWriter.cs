using System;

namespace DIP
{
    public interface IReportWriterDoc
    {
        void SetDocAsReadOnly();
        void RunDocMarco();
        void SetDocLineSpacing();
    }

    public interface IReportWriterPdf
    {
        void SetPdfCompression();
        void SetPdfEncryption();
    }

    public interface IReportWriterSpreadsheet
    {
        void LockSpreadsheetArea();
        void SetSpreadsheetDataSource();
    }

    public interface IReportWriter
    {
        string ReportName { get; set; }
        void GenerateTimeEntryReport(IPersonnel personnel);
        void SetupReportFields();
        void SetReportRecordSortOrder();
        void ShowReportHeaders(bool? showHeader);
        void ChangeReportNumericFormat();
    }
}
