using System;
using System.Collections.Generic;

public class Comment
{
    public string _name { get; private set; }
    public string _text { get; private set; }

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
}
