using TodoApp.Models;

namespace TodoApp.Pages
{
    public class AddTodo
    {
        public static Todo CreateTodo()
        {
            Console.Write("Add Your Todo Title: ");
            var getTitle = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Add Your Todo Description: ");
            var getDesciption = Console.ReadLine();

            if(!string.IsNullOrEmpty(getTitle))
            {
                return new Todo(getTitle, getDesciption);
            }
            return CreateTodo();
        }
    }
}
