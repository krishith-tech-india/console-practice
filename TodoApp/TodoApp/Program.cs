Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Todo List");
Console.ResetColor();
Console.WriteLine();

Console.Write("Enter Your name: ");
var name = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Your name: " + name );
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("-------- Your TodoList --------");
Console.ResetColor();

Console.WriteLine();
Console.WriteLine("Display todo list");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("------------------------");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("1) AddTodo");
Console.WriteLine("2) DeleteTodo");
Console.WriteLine("3) CompleteTodo");
Console.WriteLine("4) UpdateTodo");
Console.WriteLine("5) Exit");
Console.ResetColor();