using System;

namespace LSP1
{
    // new
    public class ProbationPersonnel : IPersonnel
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
                // return 0;
                throw new NotImplementedException();
            }
            
            set
            {
                // return;
                throw new NotImplementedException();
            }
        }
        public DateTime PaySchedule { get; set; }
        public double AnnualSalary { get; set; }
        public double BonusRate
        {
            get
            {
                // return 0;
                throw new NotImplementedException();
            }
            
            set
            {
                // return;
                throw new NotImplementedException();
            }
        }
        public PersonnelTypes PersonnelType { get; set; }

        public ProbationPersonnel()
        {
            PersonnelType = PersonnelTypes.Probation;
        }

        public ProbationPersonnel(long id, string name, string department, double taxDeductibles, double loanDeductibles, double medicalDeductibles, DateTime paySchedule, double annualSalary) : this()
        {
            (Id, Name, Department, TaxDeductibles, LoanDeductibles, MedicalDeductibles, PaySchedule, AnnualSalary)
            = (id, name, department, taxDeductibles, loanDeductibles, medicalDeductibles, paySchedule, annualSalary);
        }
    }
}