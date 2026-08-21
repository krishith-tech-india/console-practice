using TodoApp.Helpers;
using TodoApp.Models;
using TodoApp.Pages;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Todo> todos = new List<Todo>() {
    new Todo(
        "Learn C# Fundamentals",
        "Study classes, objects, constructors, properties, enums, and basic OOP concepts."
    ),

    new Todo(
        "Build a Todo Console App",
        "Create a console-based Todo application with options to add, update, delete, and complete tasks."
    ),

    new Todo(
        "Practice LINQ",
        "Learn and practice LINQ methods such as Where, Select, FirstOrDefault, OrderBy, and Any."
    ),

    new Todo(
        "Read a Programming Book",
        "Spend 30 minutes reading a programming book and take notes on the important concepts."
    ),

    new Todo(
        "Practice Coding Problems",
        "Solve a few beginner-friendly coding problems to improve problem-solving and logical thinking."
    )
};




while (true)
{
    Helper.ClearContent();

    Home.DisplayTodoList(todos);
    var userSelector = Home.GetHomapgeUserAction();

    Helper.ClearContent();

    switch (userSelector)
    {
        case UserChoiceEnum.AddTodo: 
            var newTodo = AddTodo.CreateTodo();
            todos.Add(newTodo);
            Console.WriteLine("Todo Created Successfully!!");
            break;

        case UserChoiceEnum.DeleteTodo:
            DeleteTodo.RemoveTodo(todos);
            break;

        case UserChoiceEnum.CompleteToto:
            CompleteTodo.Complete(todos);
            break;

        case UserChoiceEnum.UpdateTodo:
            UpdateTodo.EditTodo(todos);
            break;

        case UserChoiceEnum.Exit:
            string userChoice = Helper.ExitDialogConfirm();
            if(userChoice.Equals("Yes"))
            {
                return;
            }
            break;
    }

    Console.Write("Press Enter to Continue ");
    var x = Console.ReadLine();
}

