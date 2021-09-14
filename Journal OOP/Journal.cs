using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal_OOP
{
    public class Journal
    {
        public string PatientName { get; private set; }
        public string Address { get; private set; }
        public int PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public long Cpr { get; private set; }
        public string PatientDoctor { get; private set; }

        public Journal(string patientName, string address, int phoneNumber, string email, long cpr, string patientDoctor)
        {
            PatientName = patientName;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Cpr = cpr;
            PatientDoctor = patientDoctor;
        }

        public Journal()
        {
        }
    }
}
