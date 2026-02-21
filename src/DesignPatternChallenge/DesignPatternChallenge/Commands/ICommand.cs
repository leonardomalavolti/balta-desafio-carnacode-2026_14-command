namespace DesignPatternChallenge.Commands;

public interface ICommand
{
    void Execute();
    void Undo();
}