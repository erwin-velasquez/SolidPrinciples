using System;

namespace OCP1
{
    public interface IReportWriter
    {
        string ReportName { get; set; }
        void GenerateTimeEntryReport(Personnel personnel);
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