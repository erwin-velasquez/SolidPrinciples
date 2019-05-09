using System;
using System.Collections.Generic;

namespace OCP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnel ftEmpJohnDoe = new Personnel
            {
                Id = 1,
                Name = "John Doe",
                Department = "Acme Department",
                TaxDeductibles = 16.4D,
                LoanDeductibles = 27.3D,
                MedicalDeductibles = 25.0D,
                PaySchedule = DateTime.Now,
                AnnualSalary = 50000.00D,
                PersonnelType = Personnel.PersonnelTypes.FullTime
            };

            Personnel ftEmpJoeBloggs = new Personnel
            {
                Id = 2,
                Name = "Joe Bloggs",
                Department = "Foo Department",
                TaxDeductibles = 16.4D,
                LoanDeductibles = 27.3D,
                MedicalDeductibles = 25.0D,
                PaySchedule = DateTime.Now,
                AnnualSalary = 50000.00D,
                PersonnelType = Personnel.PersonnelTypes.FullTime
            };
            
            Personnel tmpEmpJaneDoe = new Personnel
            {
                Id = 3,
                Name = "Jane Doe",
                Department = "Bar Department",
                TaxDeductibles = 16.4D,
                LoanDeductibles = 27.3D,
                MedicalDeductibles = 25.0D,
                PaySchedule = DateTime.Now,
                AnnualSalary = 35000.00D,
                PersonnelType = Personnel.PersonnelTypes.Temporary
            };

            PayCalculator payCalc = new PayCalculator();

            List<Personnel> personnelList = new List<Personnel> { ftEmpJohnDoe, ftEmpJoeBloggs, tmpEmpJaneDoe };

            Console.WriteLine($"\nID\tNAME\t\tPERSONNELTYPE\tANNUALSALARY\tBONUS");
            personnelList.ForEach(personnel =>
                Console.WriteLine($"{personnel.Id}\t{personnel.Name}\t{personnel.PersonnelType}\t{personnel.AnnualSalary}\t\t{payCalc.CalculateBonus(personnel)}")
            );

            // Problem: Be able to add new personel types and make PayCalculator OCP
        }
    }
}
