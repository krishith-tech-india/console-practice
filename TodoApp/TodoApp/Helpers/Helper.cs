

using TodoApp.Models;
using TodoApp.Pages;

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

        public static string ExitDialogConfirm()
        {
            Console.WriteLine();
            Console.WriteLine("Do you Want to Exit?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");

            Console.WriteLine();
            Console.Write("Enter your Choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            if(userChoice == 1)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
