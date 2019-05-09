using System;

namespace LSP1
{
    // new
    public class ContractorPersonnel : IPersonnel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double TaxDeductibles { get; set; }
        public double LoanDeductibles { get; set; }
        public double MedicalDeductibles
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public DateTime PaySchedule { get; set; }
        public double AnnualSalary { get; set; }
        public double BonusRate
        {
            get
            {
                throw new NotImplementedException();
            }
            
            set
            {
                throw new NotImplementedException();
            }
        }
        public PersonnelTypes PersonnelType { get; set; }

        public ContractorPersonnel()
        {
            PersonnelType = PersonnelTypes.Contractor;
        }

        public ContractorPersonnel(long id, string name, string department, double taxDeductibles, double loanDeductibles, double medicalDeductibles, DateTime paySchedule, double annualSalary) : this()
        {
            (Id, Name, Department, TaxDeductibles, LoanDeductibles, MedicalDeductibles, PaySchedule, AnnualSalary)
            = (id, name, department, taxDeductibles, loanDeductibles, medicalDeductibles, paySchedule, annualSalary);
        }
    }
}