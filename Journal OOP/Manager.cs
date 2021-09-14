using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Journal_OOP
{
    public class Manager
    {
        List<Journal> journal = new List<Journal>();
        List<JournalEntry> journalEntries = new List<JournalEntry>();
        int patientNumber = 0;

        public void KeyRight()
        {
             
        }
        public void KeyLeft()
        {

        }

        public void GetPatientAge()
        {

        }

        public void CreatePatient(string patientNameInput, string addressInput, int patientPhoneNumber, string emailInput, long cprInput, string patientDoctorInput)
        {
            Journal patient = new Journal(patientNameInput, addressInput, patientPhoneNumber, emailInput, cprInput, patientDoctorInput);
            journal.Add(patient);
        }


        public void CreatePatientFileInfo(string folderName, string patientNameInput, string addressInput, int patientPhoneNumber, string emailInput, long cprInput, string patientDoctorInput)
        {
            string pathStringPatient = Path.Combine(folderName, "Patient" + patientNumber);
            Directory.CreateDirectory(pathStringPatient);
            StreamWriter sw = new StreamWriter(@"C:\Users\zbcmber\Documents\Journal\Patient" + patientNumber + @"\PatientInfo.txt");
            sw.WriteLine("Patient name: " + patientNameInput + "\nAddress: " + addressInput + "\nPhone number: " + patientPhoneNumber + "\nEmail: " + emailInput + "\nCpr: " + cprInput + "\nPatient doctor: " + patientDoctorInput);
            sw.Close();
            patientNumber++;
        }

        public void CreatePatientEntryFile()
        {
            
        }

        public void CreateEntry(int date, string entryDoctor, string entryText)
        {
            JournalEntry patientJournalEntry = new JournalEntry(date, entryDoctor, entryText);
            journalEntries.Add(patientJournalEntry);
        }

       
        public List<Journal> ReturnPatient()
        {
            return journal;
        }

        public void ClearMethod()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
