using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int wordToHide)
    {
        var shownWords = _words.Where(Word => !Word.IsHidden()).ToList();

        if (shownWords.Count <= wordToHide)
        {
            foreach (var word in shownWords)
            {
                word.Hide();
            }
        }
        else
        {
            Random random = new Random();
            for (int i = 0; i < wordToHide; i++)
            {
                int index = random.Next(shownWords.Count);
                shownWords[index].Hide();
                shownWords.RemoveAt(index);
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}";
        displayText += string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return displayText;
    }

    public bool CompleteHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}