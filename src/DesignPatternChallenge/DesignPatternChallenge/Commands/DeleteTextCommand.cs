using DesignPatternChallenge.Core;

namespace DesignPatternChallenge.Commands;

public class DeleteTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly int _length;
    private string _deletedText = "";
    private int _position;

    public DeleteTextCommand(TextEditor editor, int length)
    {
        _editor = editor;
        _length = length;
    }

    public void Execute()
    {
        _position = _editor.GetCursorPosition();
        var content = _editor.GetContent();

        if (_position >= _length)
        {
            _deletedText = content.Substring(_position - _length, _length);
        }

        _editor.DeleteText(_length);
    }

    public void Undo()
    {
        _editor.SetCursorPosition(_position - _length);
        _editor.InsertText(_deletedText);
    }
}
