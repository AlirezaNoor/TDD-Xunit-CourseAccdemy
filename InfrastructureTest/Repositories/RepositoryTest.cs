using Domain.Course;
using DomianTest.Builder;
using FluentAssertions;
using Infrastructrue.Course;
using Xunit;

namespace InfrastructureTest.Repositories;

public class RepositoryTest
{
    [Fact]
    public void Create()
    {
        var courseBuilderTest = new CourseBuilderTest();
        var course = courseBuilderTest.build();
        CouresRepository couresRepository = new CouresRepository();
        couresRepository.Create(course);
        // couresRepository.Courses.Should().ContainEquivalentOf(course);
        couresRepository.Courses.Should().Contain(course);
    }

    [Fact]
    public void GetAll_Course_when_we_call_All()
    {
        var couresRepository = new CouresRepository();
        var courseBuilderTest = new CourseBuilderTest();
        var course = courseBuilderTest.build();
        var actual = couresRepository.GetAll();
        couresRepository.Courses.Should().HaveCountGreaterThanOrEqualTo(0);
        
    }

    [Fact]
    public void Get_By_Id_Shoud_pass_Course()
    {
        var couresRepository = new CouresRepository();
        var courseBuilderTest = new CourseBuilderTest();
        var course = courseBuilderTest.checked_Id_is_same(3).build();
        couresRepository.Create(course);

        var actual = couresRepository.GetBy(3);

        actual.Should().Be(course);
    }

    [Fact]
    public void Get_By_Id_when_shoud_pass_null()
    {
        var couresRepository = new CouresRepository();
        var courseBuilderTest = new CourseBuilderTest();
        var actual = couresRepository.GetBy(53);

        actual.Should().BeNull();

    }

    [Fact]
    public void Delete_By_Id_when_should_pass_Id()
    {
        var courseBuilderTest = new CourseBuilderTest();
        var couresRepository = new CouresRepository();
        var corse=courseBuilderTest.checked_Id_is_same(4).build();
        couresRepository.Create(corse);

         couresRepository.Delete(4);

         couresRepository.Courses.Should().NotContain(corse);
    }
}
 