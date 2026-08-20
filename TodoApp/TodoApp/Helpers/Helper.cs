

namespace TodoApp.Helpers
{
    public class Helper
    {
        public static void ClearContent()
        {
            Console.Clear();
            PrintHeading();
        }

        public static void PrintHeading()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Todo Application");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }
        public static void AddTodo()
        {

        }

        public static void UpdateTodo()
        {

        }

        public static void DeleteTodo()
        {

        }
    }
}
