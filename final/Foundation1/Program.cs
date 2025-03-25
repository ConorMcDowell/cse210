using System;

class Program
{
    static void Main(string[] args)
    {
        Tracker track = new Tracker();
        Console.Write("How many videos are there? ");
        int videos = int.Parse(Console.ReadLine());

        for (int i = 0; i < videos; i++)
        {
            Console.Write($"What is the title of video {i + 1}? ");
            string title = Console.ReadLine();
            Console.Write("Who is the author? ");
            string author = Console.ReadLine();
            Console.Write("How long is the video in seconds? ");
            int length = int.Parse(Console.ReadLine());

            track.MakeVideo(title, author, length);
        }
        track.Display();
    }
}