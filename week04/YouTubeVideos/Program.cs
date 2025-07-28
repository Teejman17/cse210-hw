using System;
using System.Collections.Generic;
using System.Dynamic;


class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Title1", "Author1", 600);
        Video video2 = new Video("Title2", "Author2", 300);
        Video video3 = new Video("Title3", "Author3", 360);
        Video video4 = new Video("Title4", "Author4", 120);

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
        }
    }
}