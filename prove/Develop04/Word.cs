public class Word
{
    private bool _visible = true;
    private string _text = "";

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _visible = false;
    }

    public void Show()
    {
        _visible = true;
    }

    public bool IsVisible()
    {
        return _visible;
    }

    public override string ToString()
    {
        if (_visible)
        {
            return _text;
        }
        else
        {
            return "_____";
        }
    }
}