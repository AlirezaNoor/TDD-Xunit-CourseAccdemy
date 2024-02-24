using Infrastructrue.Course;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure.Course.IntegrationTest;

public class IDatabaseFixture
{
    public Acddemy context;
    public IDatabaseFixture()
    {
        var option = new DbContextOptionsBuilder<Acddemy>().UseSqlServer(
            "Server=.;Database=BlinkShop.CartShop;User Id=sa;Password=55375447;TrustServerCertificate=True"
        ).Options;
          context = new Acddemy(option);
    }
}