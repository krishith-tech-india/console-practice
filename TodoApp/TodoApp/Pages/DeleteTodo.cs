using TodoApp.Models;

namespace TodoApp.Pages
{

	public class DeleteTodo
	{
        public static void RemoveTodo(List<Todo> todos)
        {
            Home.LoadHomePage(todos);
            Console.WriteLine();


            Console.Write("Enter Delete todo Id: ");
            var isInt = int.TryParse(Console.ReadLine(), out var todoId);

            if (isInt)
            {
                var todo = todos.FirstOrDefault(todo => todo.Id == todoId);

                if (todo != null) {
                    todos.Remove(todo);
                    Console.WriteLine();
                    Console.WriteLine("Todo Deleted Successfully!!");
                    return;
                }
            }

            Console.WriteLine("Invalid Todo Id");
        }
    }
}
