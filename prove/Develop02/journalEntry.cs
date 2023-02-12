public class journalEntry
{
    public string _prompt ="";

    public string _entryDate = "";

    public string _response = "";

    public journalEntry()
    {

    }

    public void Display()
    {
        Console.WriteLine($"{_entryDate} - {_prompt}\n {_response}\n");
    }
}