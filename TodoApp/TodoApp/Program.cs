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

int userSelector = Home.LoadHomePage(todos);
 

switch (userSelector)
{
    case 1: 
        Console.WriteLine("Add Your Todo");
        break;

    case 2:
        Console.WriteLine("Delete Your Todo");
        break;

    case 3:
        Console.WriteLine("Complete Your Todo");
        break;

    case 4:
        Console.WriteLine("Update Your Todo");
        break;

    case 5:
        Console.WriteLine("Exit");
        break;

    default:
        Console.WriteLine("Invalid user selector");
        break;
}

