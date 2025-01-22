public class Resume
{
    public string _name = "";
    public List<Job> jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"{_name}");
        
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Programmer";
        job1._startYear = "2020";
        job1._endYear = "2024";
        jobs.Add(job1);

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Engineer";
        job2._startYear = "2016";
        job2._endYear = "2020";
        jobs.Add(job2);

        Job job3 = new Job();
        job3._company = "Joe's Washing Machines";
        job3._jobTitle = "Repairman";
        job3._startYear = "2010";
        job3._endYear = "2010";
        jobs.Add(job3);
        
        foreach(Job job in jobs)
        {
            job.Display();
        }
    }
}