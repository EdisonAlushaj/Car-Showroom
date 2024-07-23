using Microsoft.EntityFrameworkCore;

namespace CarShowroom_App.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
