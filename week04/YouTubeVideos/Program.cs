using System;


class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Title1", "Author1", 600);
        Video video2 = new Video("Title2", "Author2", 300);
        Video video3 = new Video("Title3", "Author3", 360);
        Video video4 = new Video("Title4", "Author4", 120);

        video1._comments.Add(new Comment("name1", "text1"));
        video1._comments.Add(new Comment("name2", "text2"));
        video1._comments.Add(new Comment("name3", "text3"));

        video2._comments.Add(new Comment("name1", "text1"));

        video3._comments.Add(new Comment("name1", "text1"));
        video3._comments.Add(new Comment("name2", "text2"));
        video3._comments.Add(new Comment("name3", "text3"));



        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length in seconds: {video._length}");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine($"Comments: ");

            if (video.NumberOfComments() == 0)
            {
                Console.WriteLine("No number of comments");
            }
            else
            {
                foreach (var comment in video._comments)
                {
                    Console.WriteLine($" - {comment._name} - {comment._text}");
                }
            }
        }
    }
}