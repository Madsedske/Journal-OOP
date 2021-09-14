using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Journal_OOP
{
    class Program
    {
        static void Main(string[] args)
        {         
            Journal journal = new Journal();
            Manager manager = new Manager();
            List<Journal> patiens = new List<Journal>();
            for (; ; )
            {                
                string folderName = @"C:\Users\zbcmber\Documents\Journal";
                Console.WriteLine("            JOURNAL \n----------------------------------");
                Console.WriteLine("1. Create Journal \n2. Search for a journal\n");
                int searchInput = Convert.ToInt32(Console.ReadLine());
                if (searchInput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Patient name:");
                    string patientNameInput = Console.ReadLine();
                    Console.WriteLine("Address:");
                    string addressInput = Console.ReadLine();
                    Console.WriteLine("Phone number:");
                    int patientPhoneNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Email:");
                    string emailInput = Console.ReadLine();
                    Console.WriteLine("Cpr:");
                    long cprInput = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Patient doctor:");
                    string patientDoctorInput = Console.ReadLine();
                    manager.CreatePatient(patientNameInput, addressInput, patientPhoneNumber, emailInput, cprInput, patientDoctorInput);
                    manager.CreatePatientFileInfo(folderName, patientNameInput, addressInput, patientPhoneNumber,  emailInput, cprInput, patientDoctorInput);       
                }
                else if (searchInput == 2)
                {

                    patiens = manager.ReturnPatient();
                    Console.WriteLine("Patient name:");
                    for (int i = 0; i < patiens.Count; i++)
                    {
                        string lookUpName = Console.ReadLine().ToLower();
                        if (patiens[i].PatientName == lookUpName)
                        {
                            Console.Clear();
                            Console.WriteLine($"Name:{manager.ReturnPatient()[i].PatientName }\nAddress:{manager.ReturnPatient()[i].Address}\nPhone number:{manager.ReturnPatient()[i].PhoneNumber}\nEmail:{manager.ReturnPatient()[i].Email}\nCPR:{manager.ReturnPatient()[i].Cpr}\nPatients doctor:{manager.ReturnPatient()[i].PatientDoctor}");
                            Console.WriteLine("Create a entry? Yes or no. - Write 'look' to see entries.");
                            string entryAnswer = Console.ReadLine().ToLower();
                            if (entryAnswer == "yes")
                            {
                                int datetime = 0;
                                Console.WriteLine("Date:");
                                Console.WriteLine("Doctor:");
                                string entryDoctor = Console.ReadLine();
                                Console.WriteLine("Entry:");
                                string entryText = Console.ReadLine();
                                manager.CreateEntry(datetime, entryDoctor, entryText);
                                
                            }
                            else if (entryAnswer == "no")
                            Console.Clear();
                            else if (entryAnswer == "look")
                            {

                            }
                        }
                        else
                        {
                            Console.WriteLine("Patient doesn't exist");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                    }                    
                }
                Console.ReadKey();
            }            
        }
    }
}