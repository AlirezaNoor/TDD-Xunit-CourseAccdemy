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

    [Fact]
    public void Check_Get_by_name()
    {
        var Name = "sdsdsd";
        var course = new Domain.Course.Course(0,  Name, true, 900);
        _couresRepository.Create(course);
    var actual=_couresRepository.getbyname( course);

    actual.Should().Be(course);


    }

    [Fact]
    public void Check_Create_right()
    {
        var Name = "sdsdsd";
        var course = new Domain.Course.Course(0,  Name, true, 900);
        _couresRepository.Create(course);
        var actual = _couresRepository.GetAll();

        actual.Should().Contain(course);
    }
    [Fact]
    public void Check_return_id()
    {
        var coures = new Domain.Course.Course(0, "alireza", true, 800);
        var id=_couresRepository.Create(coures);

        id.Should().BeGreaterThan(0);

    }
}