using System;

namespace SRP1
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

        public void Log(string log)
        {
            Console.WriteLine($"MSMQ Log: {log}");
        }

        public void SendNotification(string message)
        {
            // email component used and sent notification message
            Console.WriteLine($"Sent email: {message}");
        }

        public void SetupReportFields()
        {
            Log("Starting fields setup.");
            // processing here
            Log($"Report fields have been setup.");
        }

        public void DeactivatePersonnel()
        {
            Log("Deactivating personnel.");
            // processing here
            Log($"Personnel deactivated.");
            SendNotification("Personnel deactivated.");
        }

        public double CalculateBonus()
        {
            double bonusRate = 0.0D;

            switch(PersonnelType)
            {
                case PersonnelTypes.FullTime:
                    bonusRate = 0.15D;
                    break;
                // other types of personnel in the future
                default:
                    break;
            }

            // processing here
            return AnnualSalary * bonusRate;
        }

        public double GetSumOfDeductibles()
        {
            Log("Summing up all deductions.");
            // processing here
            Log("Summed all deductions.");
            return TaxDeductibles + LoanDeductibles + MedicalDeductibles;
        }

        public DateTime GetPaySchedule()
        {
            return PaySchedule;
        }

        public void SetReportRecordSortOrder()
        {
            Log($"Report sort order changed.");
        }

        public void GetPersonnelInformation(int personnelId)
        {
            Log($"Personnel information retrieved.");
            // for the sake of the exercise, just return an arbitrary personnel
            Id = 1;
            Name = "John Doe";
            Department = "Acme Department";
            PersonnelType = PersonnelTypes.FullTime;
            TaxDeductibles = 16.4D;
            LoanDeductibles = 27.3D;
            MedicalDeductibles = 25.0D;
            PaySchedule = DateTime.Now;
            AnnualSalary = 50000.00D;
        }

        public void ShowReportHeaders(bool? showHeader)
        {
            Log($"Show header is set to {(showHeader.HasValue ? showHeader.Value.ToString() : "Default")}");
        }

        public void RegisterPersonnel()
        {
            Log($"New personnel information created.");
            // processing here
            SendNotification("New personnel information created.");
        }

        public void PersistPersonnelUpdates()
        {
            Log($"Personnel information updated.");
            // processing here
            SendNotification("Personnel information updated.");
        }

        public double GetHourlyRate()
        {
            return AnnualSalary  / (40 * 52);
        }

        public void ChangeReportNumericFormat()
        {
            Log($"Report numeric format changed.");
        }

        public void GenerateTimeEntryReport()
        {
            // processing here
            SendNotification("Report created.");
        }

        public void SetDocAsReadOnly()
        {
            // do something here
            Log($"Doc set as readonly.");
        }

        public void RunDocMarco()
        {
            // do something here
            Log($"Ran macro.");
        }

        public void SetDocLineSpacing()
        {
            // do something here
            Log($"Doc line spacing set.");
        }

        public void LockSpreadsheetArea()
        {
            // do something here
            Log($"SpreadsheetArea locked.");
        }

        public void SetSpreadsheetDataSource()
        {
            // do something here
            Log($"Spreadsheet datasource.");
        }
    }
}
