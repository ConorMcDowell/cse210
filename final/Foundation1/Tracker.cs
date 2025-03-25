class Tracker 
{
    List<Video> videos1 = new List<Video>();

    public void MakeVideo(string title, string author, int length)
    {
        Video video1 = new Video(title, author, length);
        videos1.Add(video1);

        Console.Write("How many comments are there? ");
        int comments = int.Parse(Console.ReadLine());

        for (int i = 0; i < comments; i++)
        {
            Console.Write($"Comment {i + 1}: ");
            string text = Console.ReadLine();

            Console.Write("Author: ");
            string name = Console.ReadLine();

            video1.NewComment(name, text);
        }
    }

    public void Display()
    {   
        foreach (Video video in videos1)
        {
            string title = video.GetTitle();
            string author = video.GetAuthor();
            int length = video.GetLength();
            int comments = video.NumberComments();
            Console.WriteLine($"Title: {title} \nAuthor: {author} \nLength: {length} seconds \nNumber of comments: {comments}");
            Console.WriteLine("Comments: ");
            video.Display();
        }
    }
}