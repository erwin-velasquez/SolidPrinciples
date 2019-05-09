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

            ReportWriterDoc docRepWriter = new ReportWriterDoc();
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

            // Problem:
            // When globally changing to a new logging strategy, or changing from email notification to a new another type,
            //   the program is rigid and fragile such that you will be forced to update all dependent classes.
            //   Apply DIP on ReportWriterDoc.cs; eventually in all dependent classes of MsmqLogger and emailNotificationSender.
        }
    }
}
