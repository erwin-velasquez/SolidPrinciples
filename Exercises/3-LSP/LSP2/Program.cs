using System;
using System.Collections.Generic;

namespace LSP2
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

            IPersonnelWithBenefits ftEmpJoeBloggs = new FullTimePersonnel
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
            
            IPersonnelWithBenefits tmpEmpJaneDoe = new TemporaryPersonnel
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
            
            IPersonnel contractEmpDianneAmeter = new ContractorPersonnel
            {
                Id = 4,
                Name = "Dianne Ameter",
                Department = "Timbuktu",
                TaxDeductibles = 16.4D,
                LoanDeductibles = 27.3D,
                PaySchedule = DateTime.Now,
                AnnualSalary = 60000.00D
            };

            IPersonnel probationEmpAlanFresco = new ProbationPersonnel
            {
                Id = 5,
                Name = "Alan Fresco",
                Department = "Voldemort Ltd",
                TaxDeductibles = 16.4D,
                LoanDeductibles = 27.3D,
                PaySchedule = DateTime.Now,
                AnnualSalary = 25000.00D
            };

            PayCalculator payCalc = new PayCalculator();

            List<IPersonnelWithBenefits> personnelWithBenefitsList = new List<IPersonnelWithBenefits>
            {
                ftEmpJohnDoe, ftEmpJoeBloggs, tmpEmpJaneDoe
            };

            Console.WriteLine($"\nID\tNAME\t\tPERSONNELTYPE\tANNUALSALARY\tBONUS");
            personnelWithBenefitsList.ForEach(personnelWithBenefits =>
                Console.WriteLine($"{personnelWithBenefits.Id}\t{personnelWithBenefits.Name}\t{personnelWithBenefits.PersonnelType}\t{personnelWithBenefits.AnnualSalary}\t\t{payCalc.CalculateBonus(personnelWithBenefits)}")
            );

            List<IPersonnel> personnelList = new List<IPersonnel>
            {
                ftEmpJohnDoe, ftEmpJoeBloggs, tmpEmpJaneDoe, contractEmpDianneAmeter, probationEmpAlanFresco
            };

            Console.WriteLine($"\nID\tNAME\t\tPERSONNELTYPE\tANNUALSALARY");
            personnelList.ForEach(personnel =>
                Console.WriteLine($"{personnel.Id}\t{personnel.Name}\t{personnel.PersonnelType}\t{personnel.AnnualSalary}")
            );
        }
    }
}
