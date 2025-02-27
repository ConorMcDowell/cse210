class Listing : Activity
{
    public void List()
    {
        string name = "Listing";
        string description = "This activity will help you to list the good things in your life in a particular area.";
        
        int seconds = Start(name, description);

        Console.WriteLine("Take some time to think about the following prompt...");
        ListingActivity();
        CountDown(10);
        Console.WriteLine("Now start listing items!");
        CountDown(seconds);
        
        End(name, seconds); 
    }

    public void ListingActivity()
    {
        List<string> prompts = new List<string>();

        prompts.Add("Who are people you appreciate? ");
        prompts.Add("What are your personal strengths? ");
        prompts.Add("When have you felt the Holy Ghost this month? ");
        prompts.Add("What are some things you are grateful for? ");
        
        Random random = new Random(); 
        int random1 = random.Next(0, prompts.Count);

        Console.WriteLine($"{prompts[random1]}");
    }   
}