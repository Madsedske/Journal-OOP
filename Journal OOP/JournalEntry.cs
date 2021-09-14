using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal_OOP
{
    public class JournalEntry
    {
        public int Date { get; private set; }
        public string JournalEntryDoctor { get; private set; }
        public string Text { get; private set; }

        public JournalEntry(int date, string journalEntryDoctor, string text)
        {
            Date = date;
            JournalEntryDoctor = journalEntryDoctor;
            Text = text;
        }
    }
}
