using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words = new List<Word>();

    public Scripture(string wholeText)
    {
        string[] texts = wholeText.Split(" ");
        for (int i = 0; i < texts.Length; i++)
        {
            string text = texts[i];
            Word word = new Word(text);
            _words.Add(word);
        }
    }

    public void RandomlyHideWord()
    {
        List<Word> visibleWords = GetVisibleWords();
        Random random = new Random();
        int index  = random.Next(0, visibleWords.Count - 1);
        Word word = visibleWords[index];
        word.Hide();
    }

    public void MakeAllWordsVisible()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }

    public override string ToString()
    {
        string wholeText = "";
        foreach(Word word in _words)
        {
            string text = word.ToString();
            wholeText += $" {text}";
        }
        return wholeText;
    }

    private List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach(Word w in _words)
        {
            if (w.IsVisible())
            {
                visibleWords.Add(w);
            }
        }
        return visibleWords;
    }
}