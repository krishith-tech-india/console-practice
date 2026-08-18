using TodoApp.Models;
using TodoApp.Pages;

List<Todo> todos = new List<Todo>() { 
    new Todo("Game", "TESR") , 
    new Todo("Shdfre" , "adSD"), 
    new Todo("REEF", "FEFWEFEW"),
    new Todo("EWEW", ""),
    new Todo("LearnC#", "")
};


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Todo Application");
Console.ResetColor();
Console.WriteLine();

Home.LoadHomePage(todos);

