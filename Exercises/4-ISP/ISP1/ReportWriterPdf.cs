using System;

namespace ISP1
{
    public class ReportWriterPdf : IReportWriter
    {
        private MsmqLogger logger;
        private EmailNotificationSender emailSender;

        public string ReportName { get; set; }

        public ReportWriterPdf()
        {
            logger = new MsmqLogger();
            emailSender = new EmailNotificationSender();
        }

        public void GenerateTimeEntryReport(IPersonnel personnel)
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
            // return;
            throw new NotImplementedException();
        }

        public void RunDocMarco()
        {
            // return;
            throw new NotImplementedException();
        }

        public void SetDocLineSpacing()
        {
            // return;
            throw new NotImplementedException();
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

        public void SetPdfCompression()
        {
            // do something here
            logger.Log($"Pdf compression set.");
        }

        public void SetPdfEncryption()
        {
            // do something here
            logger.Log($"Pdf encryption set.");
        }
    }
}
