using System;

namespace LSP2
{
    public class PayCalculator
    {
        private MsmqLogger logger;

        public PayCalculator()
        {
            logger = new MsmqLogger();
        }

        public double CalculateBonus(IPersonnelWithBenefits personnel)
        {
            // processing here
            return personnel.AnnualSalary * personnel.BonusRate;
        }

        public double GetSumOfDeductibles(IPersonnelWithBenefits personnel)
        {
            logger.Log("Summing up all deductions.");
            // processing here
            logger.Log("Summed all deductions.");
            return personnel.TaxDeductibles + personnel.LoanDeductibles + personnel.MedicalDeductibles;
        }

        public DateTime GetPaySchedule(IPersonnel personnel)
        {
            return personnel.PaySchedule;
        }

        public double GetHourlyRate(IPersonnel personnel)
        {
            return personnel.AnnualSalary  / (40 * 52);
        }
    }
}
