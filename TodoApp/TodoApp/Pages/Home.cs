using TodoApp.Models;

namespace TodoApp.Pages
{
    public class Home
    {
        public static void DisplayTodoList(List<Todo> todos)
        {
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
        }

        public static UserChoiceEnum GetHomapgeUserAction()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Add Todo");
            Console.WriteLine("2) Update Todo");
            Console.WriteLine("3) Delete Todo");
            Console.WriteLine("4) Complete Todo");
            Console.WriteLine("5) Exit");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Enter your Selection : ");

            var correctNumberFormat = Enum.TryParse<UserChoiceEnum>(Console.ReadLine(), out var userChoice);
            var isDefinedEnumValue = Enum.IsDefined(typeof(UserChoiceEnum), userChoice);

            if (!correctNumberFormat || !isDefinedEnumValue)
            {
                Console.WriteLine("Invalid Selection, Please select Again!!");
                Console.WriteLine();
                return GetHomapgeUserAction();
            }
            
            Console.ResetColor();
            Console.WriteLine();
            return userChoice;

        }
    }
}
