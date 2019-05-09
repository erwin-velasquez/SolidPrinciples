using System;

namespace LSP2
{
    public interface IReportWriter
    {
        string ReportName { get; set; }
        void GenerateTimeEntryReport(IPersonnel personnel);
        void SetupReportFields();
        void SetReportRecordSortOrder();
        void ShowReportHeaders(bool? showHeader);
        void ChangeReportNumericFormat();
        void SetDocAsReadOnly();
        void RunDocMarco();
        void SetDocLineSpacing();
        void LockSpreadsheetArea();
        void SetSpreadsheetDataSource();
    }
}