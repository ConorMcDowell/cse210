class PromptGenerator
{
    List<string> prompts = new List<string>();
    public void MakeList()
    {
       prompts.Add("What was your favorite thing you did today? ");
       prompts.Add("Who was your favorite person you talked to today? ");
       prompts.Add("What did you eat for lunch today? ");
       prompts.Add("What were some goals you accomplished today? ");
       prompts.Add("What is something you want to do tomorrow? ");
       prompts.Add("Where did you go today and why? ");
    }
    public void Display()
    {   
       Random random = new Random(); 
       int random1 = random.Next(0, prompts.Count);
       Console.WriteLine($"{prompts[random1]}");
    }
}