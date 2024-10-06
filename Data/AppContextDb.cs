using crud.Models;
using Microsoft.EntityFrameworkCore;

namespace crud.Data
{
    public class AppContextDb : DbContext
    {
        public DbSet<Todo> Todos {get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        =>optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
        
    }
}
