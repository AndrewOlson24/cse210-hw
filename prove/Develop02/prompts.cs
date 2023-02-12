public class Prompt
{
    public List<string> _prompts = new List<string>
    {
        "Who is the coolest person i talked to today?",
        "Best part of the day?",
        "Did you think to pray?",
        "What did you feel today?",
        "Did you learn anything cool today?",
        "Did you remember to do you tasks for today?"

    };
    
    public string GetPrompt()
    {
        Random _rnd = new Random();
        return _prompts[_rnd.Next(_prompts.Count)];
    }
}