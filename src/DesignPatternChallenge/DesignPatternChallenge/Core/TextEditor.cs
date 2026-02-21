namespace DesignPatternChallenge.Core;

public class TextEditor
{
    private string _content = "";
    private int _cursorPosition = 0;

    public void InsertText(string text)
    {
        _content = _content.Insert(_cursorPosition, text);
        _cursorPosition += text.Length;
        Console.WriteLine($"[Editor] Inserido: '{text}'");
    }

    public void DeleteText(int length)
    {
        if (_cursorPosition >= length)
        {
            _content = _content.Remove(_cursorPosition - length, length);
            _cursorPosition -= length;
            Console.WriteLine($"[Editor] {length} caracteres removidos");
        }
    }

    public void SetBold(int start, int length)
    {
        Console.WriteLine($"[Editor] Aplicando negrito de {start} até {start + length}");
    }

    public void RemoveBold(int start, int length)
    {
        Console.WriteLine($"[Editor] Removendo negrito de {start} até {start + length}");
    }

    public void SetCursorPosition(int position)
    {
        _cursorPosition = position;
    }

    public string GetContent() => _content;
    public int GetCursorPosition() => _cursorPosition;
}