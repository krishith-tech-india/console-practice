using TodoApp.Models;

namespace TodoApp.Pages
{
    public class UpdateTodo
    {
        public static void EditTodo(List<Todo> todos)
        {
            Home.LoadHomePage(todos);
            Console.WriteLine();

            Console.Write("Enter your Todo Id Which one you need to Update: ");
            var isInt = int.TryParse(Console.ReadLine(), out var todoId);

            if (isInt)
            {
                var todo = todos.FirstOrDefault(todo => todo.Id == todoId);

                if(todo != null)
                {
                    Console.Write("Enter your Update Title: ");
                    string newTitle = Console.ReadLine();

                    Console.Write("Enter your Update Description: ");
                    string newDesc = Console.ReadLine();

                    todo.Title = newTitle;
                    todo.Description = newDesc;

                    Console.WriteLine();
                    Console.WriteLine("Todo Updated Successfully");

                    return;
                }
            }

            Console.WriteLine("Todo not Found!!");

        }
    }
}
