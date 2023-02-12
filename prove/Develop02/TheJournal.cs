namespace JournalProject
{
    public class Journal
    {
        List<journalEntry> journalEntries = new List<journalEntry>();

         Prompt prompt= new Prompt();

        string delim = "|";

        Storage files;

        public journal()
        {
        files = new Storage();
        }


        public void AddEntry()
        {
            journalEntry entry = new journalEntry();

            Prompt p = new Prompt();
            string currentPrompt = p.GetPrompt();
            Console.WriteLine(currentPrompt);

            entry._entryDate =  DateTime.Now.ToString();
            entry._prompt = currentPrompt;
            entry._response = Console.ReadLine();

            Console.WriteLine(entry._entryDate+delim+entry._prompt+delim+entry._response);
        }




        public void DisplayAll()
        {
            Console.WriteLine($"Number of Journal Entry to show: {journalEntries.Count}\n");
            foreach(journalEntry entry in journalEntries)
            {
                entry.Display();
            }

            Console.WriteLine($"end of journal\n" );
        }


        public void SaveTOFile()
        {
            Console.WriteLine($"Ok, Saving to the journal");
            //files.ClearLines();
            foreach(journalEntry entry in journalEntries)
            {
                //files.addline($"{entry._entryDate}{delim}{entry._prompt}{delim}{entry._response}");
                
            }
            string filename = files.writeFile();
            Console.WriteLine($"{journalEntries.Count} journal entries written");

        }



        public void ReadFromFIle()
        {
            Console.WriteLine($"Reading a Journal");
            string filename = files.readFiles();

            foreach(string line in files.lines)
            {
                journalEntry entry = new journalEntry();
                string[] parts = line.Split(delim);

                entry._entryDate = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];
                journalEntries.Add(entry);

            }
            Console.WriteLine($"{journalEntries.Count} entries added to the journal");
        }

        public void Menu()
        {
            Console.WriteLine("welcome to your personal online Journal");
            string selection = "";
            while(selection != "5")
            {
                Console.Write("Here is your options: 1-Write, 2- Display, 3-Load, 4-save, 5-quit ");
                selection = Console.ReadLine();
                Console.WriteLine();

                if(selection == "1")
                {
                    AddEntry();
                }
                else if(selection == "2")
                {
                    DisplayAll();
                }
                else if(selection == "3")
                {
                    ReadFromFIle();
                }
                else if(selection == "4")
                {
                    SaveTOFile();
                }
                else if(selection == "5")
                {
                    Console.WriteLine("Thanks for playing. bye");
                }
                else
                {
                    Console.WriteLine("didnt Catch that, try again?");
                }
            }
        }
    }
}