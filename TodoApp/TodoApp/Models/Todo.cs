

namespace TodoApp.Models
{
    public class Todo
    {
        private static int id;
        public int Id { get;}
        public string Title {  get; set; }
        public string? Description {  get; set; }
        public bool IsCompleted { get; set; }
        public Todo(string title, string? description)
        {
            Id = ++id;
            Title = title;
            Description = description;
            IsCompleted = false;
        }

        public void DisplayTodo()
        {
            Console.WriteLine($"{Id}. {(IsCompleted ? "✔" : "⭕")}  {Title}\n-  {Description}\n");
        }
    }
}
