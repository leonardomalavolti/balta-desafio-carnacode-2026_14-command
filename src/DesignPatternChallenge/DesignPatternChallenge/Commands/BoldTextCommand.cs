using DesignPatternChallenge.Core;

namespace DesignPatternChallenge.Commands;

public class BoldTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly int _start;
    private readonly int _length;

    public BoldTextCommand(TextEditor editor, int start, int length)
    {
        _editor = editor;
        _start = start;
        _length = length;
    }

    public void Execute()
    {
        _editor.SetBold(_start, _length);
    }

    public void Undo()
    {
        _editor.RemoveBold(_start, _length);
    }
}
