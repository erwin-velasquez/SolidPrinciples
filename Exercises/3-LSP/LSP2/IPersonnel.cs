using System;

namespace LSP2
{
    public enum PersonnelTypes
    {
        FullTime, Temporary, Contractor, Probation
    }

    public interface IPersonnel
    {
        long Id { get; set; }
        string Name { get; set; }
        string Department { get; set; }
        double TaxDeductibles { get; set; }
        double LoanDeductibles { get; set; }
        DateTime PaySchedule { get; set; }
        double AnnualSalary { get; set; }
        PersonnelTypes PersonnelType { get; set; }
    }

    public interface IPersonnelWithBenefits : IPersonnel
    {
        double BonusRate { get; set; }
        double MedicalDeductibles { get; set; }
    }
}