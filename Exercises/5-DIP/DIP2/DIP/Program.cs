using System;
using System.Collections.Generic;

namespace DIP
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

            ReportWriterDoc docRepWriter = new ReportWriterDoc(new MsmqLogger(), new EmailNotificationSender());
            docRepWriter.ReportName = "Document Report";
            docRepWriter.SetupReportFields();
            docRepWriter.SetReportRecordSortOrder();
            docRepWriter.ShowReportHeaders(null);
            docRepWriter.ChangeReportNumericFormat();
            docRepWriter.SetDocAsReadOnly();
            docRepWriter.RunDocMarco();
            docRepWriter.SetDocLineSpacing();

            Console.WriteLine("\nReports ready.");
            docRepWriter.GenerateTimeEntryReport(ftEmpJohnDoe);

        }
    }
}
