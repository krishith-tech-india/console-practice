using TodoApp.Models;

namespace TodoApp.Pages
{
    public class CompleteTodo
    {
        public static void Complete(List<Todo> todos)
        {
            Home.DisplayTodoList(todos);

            Console.WriteLine();
            Console.Write("Enter your Todo Id: ");
            var isInt = int.TryParse(Console.ReadLine(), out var todoId);

            if (isInt)
            {
                var todo = todos.FirstOrDefault(todo => todo.Id == todoId);

                if(todo != null)
                {
                    todo.IsCompleted = true;
                    Console.WriteLine("Todo Completed Successfully!!");
                    return;
                }
            }


            Console.WriteLine("Invalid Todo Id");

        }
    }
}
