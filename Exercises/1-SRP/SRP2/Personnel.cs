using System;

namespace SRP2
{
    public class Personnel
    {
        public enum PersonnelTypes
        {
            FullTime // and there may be other types in the future
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double TaxDeductibles { get; set; }
        public double LoanDeductibles { get; set; }
        public double MedicalDeductibles { get; set; }
        public DateTime PaySchedule { get; set; }
        public double AnnualSalary { get; set; }
        public PersonnelTypes PersonnelType { get; set; }

        public Personnel()
        {

        }

        public Personnel(long id, string name, string department, double taxDeductibles, double loanDeductibles, double medicalDeductibles, DateTime paySchedule, double annualSalary, PersonnelTypes personnelType)
        {
            (Id, Name, Department, TaxDeductibles, LoanDeductibles, MedicalDeductibles, PaySchedule, AnnualSalary, PersonnelType)
            = (id, name, department, taxDeductibles, loanDeductibles, medicalDeductibles, paySchedule, annualSalary, personnelType);
        }
    }
}
