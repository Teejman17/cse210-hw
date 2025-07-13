using System;

public class PromptGenerator
{
    public List<string> _promptList = new List<string>()
    {
        "What was the best part of my day? ",
        "If I had one thing I could do over, what would it be? ",
        "What is one thing I learned today? ",
        "Explain a happy moment from today. ",
        "Who is someone you thought about and contacted? What did you talk about? ",
        "Describe a moment where you recognized the Lord's hand. ",
        "What is one thing I learned today? "
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    
}