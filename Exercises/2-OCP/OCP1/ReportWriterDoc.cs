using System;

namespace OCP1
{
    public class ReportWriterDoc : IReportWriter
    {
        private MsmqLogger logger;
        private EmailNotificationSender emailSender;

        public string ReportName { get; set; }

        public ReportWriterDoc()
        {
            logger = new MsmqLogger();
            emailSender = new EmailNotificationSender();
        }

        public void GenerateTimeEntryReport(Personnel personnel)
        {
            // processing here
            emailSender.SendNotification($"{ReportName}: Report created.");
        }

        public void SetupReportFields()
        {
            logger.Log("Starting fields setup.");
            // processing here
            logger.Log($"Report fields have been setup.");
        }

        public void SetReportRecordSortOrder()
        {
            logger.Log($"Report sort order changed.");
        }

        public void ShowReportHeaders(bool? showHeader)
        {
            logger.Log($"Show header is set to {(showHeader.HasValue ? showHeader.Value.ToString() : "Default")}");
        }

        public void ChangeReportNumericFormat()
        {
            logger.Log($"Report numeric format changed.");
        }

        public void SetDocAsReadOnly()
        {
            // do something here
            logger.Log($"Doc set as readonly.");
        }

        public void RunDocMarco()
        {
            // do something here
            logger.Log($"Ran macro.");
        }

        public void SetDocLineSpacing()
        {
            // do something here
            logger.Log($"Doc line spacing set.");
        }

        public void LockSpreadsheetArea()
        {
            // return;
            throw new NotImplementedException();
        }

        public void SetSpreadsheetDataSource()
        {
            // return;
            throw new NotImplementedException();
        }
    }
}
