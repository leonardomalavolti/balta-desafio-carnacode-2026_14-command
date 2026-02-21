using DesignPatternChallenge.Commands;
using DesignPatternChallenge.Core;
using DesignPatternChallenge.Invoker;

Console.WriteLine("=== Editor com Command Pattern ===\n");

var editor = new TextEditor();
var invoker = new EditorInvoker();

invoker.ExecuteCommand(new InsertTextCommand(editor, "Hello"));
invoker.ExecuteCommand(new InsertTextCommand(editor, " World"));

Console.WriteLine($"\nConteúdo: {editor.GetContent()}");

invoker.ExecuteCommand(new DeleteTextCommand(editor, 6));

Console.WriteLine($"\nConteúdo após delete: {editor.GetContent()}");

Console.WriteLine("\n--- Undo ---");
invoker.Undo();
Console.WriteLine($"Conteúdo: {editor.GetContent()}");

Console.WriteLine("\n--- Undo novamente ---");
invoker.Undo();
Console.WriteLine($"Conteúdo: {editor.GetContent()}");

Console.WriteLine("\n--- Redo ---");
invoker.Redo();
Console.WriteLine($"Conteúdo: {editor.GetContent()}");

Console.ReadLine();