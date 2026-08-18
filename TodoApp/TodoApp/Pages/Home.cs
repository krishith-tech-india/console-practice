using TodoApp.Models;

namespace TodoApp.Pages
{
    public class Home
    {
        public static void LoadHomePage(List<Todo> todos)
        {
            Console.Write("Enter Your name: ");
            var name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Your name: " + name);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-------- Your TodoList --------");
            Console.ResetColor();

            Console.WriteLine();
            foreach (var todo in todos)
            {
                todo.DisplayTodo();
            }
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
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Enter your Selector : ");
            int userSelector = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

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

        }
    }
}
