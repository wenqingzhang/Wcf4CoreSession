using System.Data.Entity;

namespace TodoWcfService
{
    public class TodoContext: DbContext
    {
        public TodoContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<TodoItem> Todos { get; set; }
    }
}