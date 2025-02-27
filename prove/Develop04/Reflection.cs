class Reflection : Activity 
{
    public void Reflect()
    {
        string name = "Reflecting";
        string description = "This activity will help you to reflect on times you showed resilience and how you can use that resilience in other areas of your life.";
        
        int seconds = Start(name, description);

        PromptGenerator();

        QuestionGenerator(seconds);
        
        End(name, seconds); 
    }

    public void PromptGenerator()
    {
        List<string> prompts = new List<string>();

        prompts.Add("Reflect on a time you overcame something difficult");
        prompts.Add("Think of something selfless you did");
        prompts.Add("Think of a hard time you went through and how you overcame it");
        prompts.Add("Reflect on how you have helped someone in need");
        
        Random random = new Random(); 
        int random1 = random.Next(0, prompts.Count);

        Console.WriteLine($"{prompts[random1]}");
    }

    public void QuestionGenerator(int seconds)
    {
        List<string> questions = new List<string>();

        questions.Add("Why was this experience meaningful to you? ");
        questions.Add("How did you feel when it was complete? ");
        questions.Add("What could you learn from this experience that applies to other situations? ");
        questions.Add("What did you learn about yourself from this experience? ");
        questions.Add("How did you feel when it was complete? ");
        questions.Add("How can you keep this experience in mind in the future? ");

        Random random = new Random(); 

        for (int i = 0; i < seconds; i += 10)
        {
            int random1 = random.Next(0, questions.Count);
            Console.WriteLine($"{questions[random1]}"); 
            CountDown(10);
        }       
    }


}