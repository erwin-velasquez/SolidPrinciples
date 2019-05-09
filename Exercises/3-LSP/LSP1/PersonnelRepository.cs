using System;

namespace LSP1
{
    public class PersonnelRepository
    {
        private MsmqLogger logger;
        private EmailNotificationSender emailSender;

        public PersonnelRepository()
        {
            logger = new MsmqLogger();
            emailSender = new EmailNotificationSender();
        }

        public void DeactivatePersonnel(IPersonnel personnel)
        {
            logger.Log("Deactivating personnel.");
            // processing here
            logger.Log($"Personnel deactivated.");
            emailSender.SendNotification("Personnel deactivated.");
        }

        public IPersonnel GetPersonnelInformation(int personnelId)
        {
            logger.Log($"Personnel information retrieved.");
            // for the sake of the exercise, just return an arbitrary personnel
            return new FullTimePersonnel
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
        }

        public void RegisterPersonnel(IPersonnel personnel)
        {
            logger.Log($"New personnel information created.");
            // processing here
            emailSender.SendNotification("New personnel information created.");
        }

        public void PersistPersonnelUpdates(IPersonnel personnel)
        {
            logger.Log($"Personnel information updated.");
            // processing here
            emailSender.SendNotification("Personnel information updated.");
        }
    }
}