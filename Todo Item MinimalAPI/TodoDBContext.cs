using Microsoft.EntityFrameworkCore;

namespace Todo_Item_MinimalAPI
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
