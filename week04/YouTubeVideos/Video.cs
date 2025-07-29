using System;
using System.Collections.Generic;

public class Video
{
    public string _title { get; private set; }
    public string _author { get; private set; }
    public int _length { get; private set; }
    public List<Comment> _comments { get; private set; }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

}