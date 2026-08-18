using TodoApp.Models;

namespace TodoApp.Pages
{
    public class Home
    {
        public static int LoadHomePage(List<Todo> todos)
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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------");
            Console.ResetColor();

           return DisplayTodoActionList();
        }

        public static int DisplayTodoActionList()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Add Todo");
            Console.WriteLine("2) Delete Todo");
            Console.WriteLine("3) Complete Todo");
            Console.WriteLine("4) Update Todo");
            Console.WriteLine("5) Exit");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Enter your Selector : ");
            var userSelector = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            return userSelector;
        }
    }
}
