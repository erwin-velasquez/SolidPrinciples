using System;

namespace SRP2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonnelRepository empRepo = new PersonnelRepository();
            PayCalculator payCalc = new PayCalculator();
            
            Personnel existingPersonnel = empRepo.GetPersonnelInformation(1);

            double hourlyRate = payCalc.GetHourlyRate(existingPersonnel);
            DateTime paySchedule = payCalc.GetPaySchedule(existingPersonnel);
            double sumDeductibles = payCalc.GetSumOfDeductibles(existingPersonnel);

            // make some changes on the Personnel info then save
            empRepo.PersistPersonnelUpdates(existingPersonnel);

            IReportWriter reportWriter = new ReportWriterDoc();
            reportWriter.ReportName = "Document Report";
            reportWriter.ChangeReportNumericFormat();
            reportWriter.SetReportRecordSortOrder();
            reportWriter.SetupReportFields();
            reportWriter.ShowReportHeaders(true);
            reportWriter.GenerateTimeEntryReport(existingPersonnel);

            IReportWriter reportWriterSpreadsheet = new ReportWriterSpreadsheet();
            reportWriterSpreadsheet.ReportName = "Spreadsheet Report";
            reportWriterSpreadsheet.ChangeReportNumericFormat();
            reportWriterSpreadsheet.SetReportRecordSortOrder();
            reportWriterSpreadsheet.SetupReportFields();
            reportWriterSpreadsheet.ShowReportHeaders(true);
            reportWriterSpreadsheet.GenerateTimeEntryReport(existingPersonnel);

            Personnel newPersonnel = new Personnel(2, "Joe Bloggs", "Foo Department", 16.4D, 27.3D, 25.0D, DateTime.Now, 50000.00D, Personnel.PersonnelTypes.FullTime);
            empRepo.RegisterPersonnel(newPersonnel);

            Console.WriteLine($"\nID\tNAME\t\tPERSONNELTYPE\tANNUALSALARY\tBONUS");
            Console.WriteLine($"{existingPersonnel.Id}\t{existingPersonnel.Name}\t{existingPersonnel.PersonnelType}\t{existingPersonnel.AnnualSalary}\t\t{payCalc.CalculateBonus(existingPersonnel)}");
            Console.WriteLine($"{newPersonnel.Id}\t{newPersonnel.Name}\t{newPersonnel.PersonnelType}\t{newPersonnel.AnnualSalary}\t\t{payCalc.CalculateBonus(newPersonnel)}\n");

            empRepo.DeactivatePersonnel(existingPersonnel);
        }
    }
}
