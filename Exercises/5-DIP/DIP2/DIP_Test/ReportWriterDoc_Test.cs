using System;
using Xunit;
using DIP;

namespace DIP_Test
{
    public class ReportWriterDoc_Test
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        [InlineData(null)]
        public void ShowReportHeaders(bool? showHeader)
        {
            ReportWriterDoc docRepWriter = new ReportWriterDoc(new FileLogger(), new MockUpNotificationSender());
            docRepWriter.ReportName = "Document Report";
            Exception ex = Record.Exception(()=>docRepWriter.ShowReportHeaders(showHeader));

            Assert.Null(ex);
        }

        [Fact]
        public void GenerateTimeEntryReport_Test()
        {
            IPersonnel personnel = new FullTimePersonnel
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

            ReportWriterDoc docRepWriter = new ReportWriterDoc(new FileLogger(), new MockUpNotificationSender());
            docRepWriter.ReportName = "Document Report";
            Exception ex = Record.Exception(()=>docRepWriter.GenerateTimeEntryReport(personnel));

            Assert.Null(ex);
        }
    }
}
