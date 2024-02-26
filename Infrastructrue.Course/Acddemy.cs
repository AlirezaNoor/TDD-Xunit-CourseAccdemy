using Microsoft.EntityFrameworkCore;

namespace Infrastructrue.Course;

public class Acddemy:DbContext
{
    public Acddemy(DbContextOptions<Acddemy> options) : base(options)
    {
    }

    public DbSet<Domain.Course.Course> courses { get; set; }
}