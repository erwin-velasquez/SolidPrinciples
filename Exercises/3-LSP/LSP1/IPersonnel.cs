using System;

namespace LSP1
{
    public enum PersonnelTypes
    {
        FullTime, Temporary,
        // new
        Contractor, Probation
    }

    public interface IPersonnel
    {
        long Id { get; set; }
        string Name { get; set; }
        string Department { get; set; }
        double TaxDeductibles { get; set; }
        double LoanDeductibles { get; set; }
        double MedicalDeductibles { get; set; }
        DateTime PaySchedule { get; set; }
        double AnnualSalary { get; set; }
        double BonusRate { get; set; }
        PersonnelTypes PersonnelType { get; set; }
    }
}