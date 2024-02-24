using FluentAssertions;
using Infrastructrue.Course;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace InfraStructure.Course.IntegrationTest;

public class DatabaseTest:IClassFixture<IDatabaseFixture>
{
    private readonly CouresRepository _couresRepository;
    public DatabaseTest(IDatabaseFixture context)
    {
        _couresRepository = new CouresRepository(context.context);
    }
    [Fact]
    public void check_database_integration_in_data_base()
    {
       
       
        var All = _couresRepository.GetAll();
        All.Should().NotBeNull();
    }

    [Fact]
    public void check_Course_Was_create_indatabase()
    {
        
        var course = new Domain.Course.Course(0, "alireza", true, 900);
        _couresRepository.Create(course);
        var all = _couresRepository.GetAll();

        all.Should().Contain(course);
    }
}