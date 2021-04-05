using System.Data.Entity;

namespace Azurefunction
{
    public class TodoContext : DbContext
    {
        public TodoContext() : base("TodoContext")
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}