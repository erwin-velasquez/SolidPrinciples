using System;
using System.Collections.Generic;

namespace LSP1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonnel ftEmpJohnDoe = new FullTimePersonnel
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

            IPersonnel ftEmpJoeBloggs = new FullTimePersonnel
            {
                Id = 2,
                Name = "Joe Bloggs",
                Department = "Foo Department",
                TaxDeductibles = 16.4D,
                LoanDeductibles = 27.3D,
                MedicalDeductibles = 25.0D,
                PaySchedule = DateTime.Now,
                AnnualSalary = 50000.00D
            };
            
            IPersonnel tmpEmpJaneDoe = new TemporaryPersonnel
            {
                Id = 3,
                Name = "Jane Doe",
                Department = "Bar Department",
                TaxDeductibles = 16.4D,
                LoanDeductibles = 27.3D,
                MedicalDeductibles = 25.0D,
                PaySchedule = DateTime.Now,
                AnnualSalary = 35000.00D
            };
            
            // new
            IPersonnel contractEmpDianneAmeter = new ContractorPersonnel
            {
                Id = 4,
                Name = "Dianne Ameter",
                Department = "Timbuktu",
                TaxDeductibles = 16.4D,
                LoanDeductibles = 27.3D,
                //MedicalDeductibles = 25.0D,
                PaySchedule = DateTime.Now,
                AnnualSalary = 60000.00D
            };

            // new
            IPersonnel probationEmpAlanFresco = new ProbationPersonnel
            {
                Id = 5,
                Name = "Alan Fresco",
                Department = "Voldemort Ltd",
                TaxDeductibles = 16.4D,
                LoanDeductibles = 27.3D,
                //MedicalDeductibles = 25.0D,
                PaySchedule = DateTime.Now,
                AnnualSalary = 25000.00D
            };

            PayCalculator payCalc = new PayCalculator();

            List<IPersonnel> personnelList = new List<IPersonnel>
            {
                ftEmpJohnDoe, ftEmpJoeBloggs, tmpEmpJaneDoe, contractEmpDianneAmeter, probationEmpAlanFresco
            };

            Console.WriteLine($"\nID\tNAME\t\tPERSONNELTYPE\tANNUALSALARY\tBONUS");
            personnelList.ForEach(personnel =>
                Console.WriteLine($"{personnel.Id}\t{personnel.Name}\t{personnel.PersonnelType}\t{personnel.AnnualSalary}\t\t{payCalc.CalculateBonus(personnel)}")
            );

            // Problem: Contractor and Probation does should not have Benefits.  Get rid of code smells.
        }
    }
}
