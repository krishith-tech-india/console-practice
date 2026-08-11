

namespace TodoApp.TodoActions
{
    public class TodoActions
    {
        public int Id {  get; set; }
        public string Title {  get; set; }
        public string Description {  get; set; }

        public string DisplayTodoList()
        {
            return $"{Id} {Title} {Description}";
        }

        public void AddTodo(string title, string description)
        {

        }

        public void UpdateTodo()
        {

        }

        public void DeleteTodo()
        {

        }
    }
}
