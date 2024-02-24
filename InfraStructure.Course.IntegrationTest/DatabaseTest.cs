using FluentAssertions;
using Infrastructrue.Course;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace InfraStructure.Course.IntegrationTest;

public class DatabaseTest
{
    [Fact]
    public void check_database_integration_in_data_base()
    {
        var option = new DbContextOptionsBuilder<Acddemy>().UseSqlServer(
            "Server=.;Database=BlinkShop.CartShop;User Id=sa;Password=55375447;TrustServerCertificate=True"
        ).Options;
        var context = new Acddemy(option);
        var repository = new CouresRepository(context);
       var All= repository.GetAll();
       All.Should().NotBeNull();

    }
}