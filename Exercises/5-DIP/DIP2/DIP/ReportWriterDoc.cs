using System;

namespace DIP
{
    public class ReportWriterDoc : IReportWriter, IReportWriterDoc
    {
        private ILogger _logger;
        private INotificationSender _notificationSender;

        public string ReportName { get; set; }

        public ReportWriterDoc(ILogger logger, INotificationSender notificationSender)
        {
            _logger = logger;
            _notificationSender = notificationSender;
        }

        public void GenerateTimeEntryReport(IPersonnel personnel)
        {
            // processing here
            _notificationSender.SendNotification($"{ReportName}: Report created.");
        }

        public void SetupReportFields()
        {
            _logger.Log("Starting fields setup.");
            // processing here
            _logger.Log($"Report fields have been setup.");
        }

        public void SetReportRecordSortOrder()
        {
            _logger.Log($"Report sort order changed.");
        }

        public void ShowReportHeaders(bool? showHeader)
        {
            _logger.Log($"Show header is set to {(showHeader.HasValue ? showHeader.Value.ToString() : "Default")}");
        }

        public void ChangeReportNumericFormat()
        {
            _logger.Log($"Report numeric format changed.");
        }

        public void SetDocAsReadOnly()
        {
            // do something here
            _logger.Log($"Doc set as readonly.");
        }

        public void RunDocMarco()
        {
            // do something here
            _logger.Log($"Ran macro.");
        }

        public void SetDocLineSpacing()
        {
            // do something here
            _logger.Log($"Doc line spacing set.");
        }
    }
}