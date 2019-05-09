using System;

namespace ISP2
{
    public class TemporaryPersonnel : IPersonnelWithBenefits
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double TaxDeductibles { get; set; }
        public double LoanDeductibles { get; set; }
        public double MedicalDeductibles { get; set; }
        public DateTime PaySchedule { get; set; }
        public double AnnualSalary { get; set; }
        public double BonusRate { get; set; }
        public PersonnelTypes PersonnelType { get; set; }

        public TemporaryPersonnel()
        {
            BonusRate = 0.10D;
            PersonnelType = PersonnelTypes.Temporary;
        }

        public TemporaryPersonnel(long id, string name, string department, double taxDeductibles, double loanDeductibles, double medicalDeductibles, DateTime paySchedule, double annualSalary) : this()
        {
            (Id, Name, Department, TaxDeductibles, LoanDeductibles, MedicalDeductibles, PaySchedule, AnnualSalary)
            = (id, name, department, taxDeductibles, loanDeductibles, medicalDeductibles, paySchedule, annualSalary);
        }
    }
}