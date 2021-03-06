using System;

namespace ISP2
{
    public class ContractorPersonnel : IPersonnel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double TaxDeductibles { get; set; }
        public double LoanDeductibles { get; set; }
        public DateTime PaySchedule { get; set; }
        public double AnnualSalary { get; set; }
        public PersonnelTypes PersonnelType { get; set; }

        public ContractorPersonnel()
        {
            PersonnelType = PersonnelTypes.Contractor;
        }

        public ContractorPersonnel(long id, string name, string department, double taxDeductibles, double loanDeductibles, DateTime paySchedule, double annualSalary) : this()
        {
            (Id, Name, Department, TaxDeductibles, LoanDeductibles, PaySchedule, AnnualSalary)
            = (id, name, department, taxDeductibles, loanDeductibles, paySchedule, annualSalary);
        }
    }
}