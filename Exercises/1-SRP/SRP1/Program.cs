using System;

namespace SRP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnel existingPersonnel = new Personnel();
            existingPersonnel.GetPersonnelInformation(1);

            double hourlyRate = existingPersonnel.GetHourlyRate();
            DateTime paySchedule = existingPersonnel.GetPaySchedule();
            double sumDeductibles = existingPersonnel.GetSumOfDeductibles();

            // make some changes on the personnel info then save
            existingPersonnel.PersistPersonnelUpdates();

            existingPersonnel.ChangeReportNumericFormat();
            existingPersonnel.SetReportRecordSortOrder();
            existingPersonnel.SetupReportFields();
            existingPersonnel.ShowReportHeaders(true);
            existingPersonnel.GenerateTimeEntryReport();

            Personnel newPersonnel = new Personnel(2, "Joe Bloggs", "Foo Department", 16.4D, 27.3D, 25.0D, DateTime.Now, 50000.00D, Personnel.PersonnelTypes.FullTime);
            newPersonnel.RegisterPersonnel();
            
            Console.WriteLine($"\nID\tNAME\t\tPERSONNELTYPE\tANNUALSALARY\tBONUS");
            Console.WriteLine($"{existingPersonnel.Id}\t{existingPersonnel.Name}\t{existingPersonnel.PersonnelType}\t{existingPersonnel.AnnualSalary}\t\t{existingPersonnel.CalculateBonus()}");
            Console.WriteLine($"{newPersonnel.Id}\t{newPersonnel.Name}\t{newPersonnel.PersonnelType}\t{newPersonnel.AnnualSalary}\t\t{newPersonnel.CalculateBonus()}\n");

            existingPersonnel.DeactivatePersonnel();

            // Problem: Apply SRP on Personnel.cs
        }
    }
}
