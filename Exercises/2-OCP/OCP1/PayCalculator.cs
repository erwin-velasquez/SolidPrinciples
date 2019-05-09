using System;

namespace OCP1
{
    public class PayCalculator
    {
        private MsmqLogger logger;

        public PayCalculator()
        {
            logger = new MsmqLogger();
        }

        public double CalculateBonus(Personnel personnel)
        {
            double bonusRate = 0.0D;

            switch(personnel.PersonnelType)
            {
                case Personnel.PersonnelTypes.FullTime:
                    bonusRate = 0.15D;
                    break;
                // new
                case Personnel.PersonnelTypes.Temporary:
                    bonusRate = 0.10D;
                    break;
                default:
                    break;
            }

            // processing here
            return personnel.AnnualSalary * bonusRate;
        }

        public double GetSumOfDeductibles(Personnel personnel)
        {
            logger.Log("Summing up all deductions.");
            // processing here
            logger.Log("Summed all deductions.");
            return personnel.TaxDeductibles + personnel.LoanDeductibles + personnel.MedicalDeductibles;
        }

        public DateTime GetPaySchedule(Personnel personnel)
        {
            return personnel.PaySchedule;
        }

        public double GetHourlyRate(Personnel personnel)
        {
            return personnel.AnnualSalary  / (40 * 52);
        }
    }
}