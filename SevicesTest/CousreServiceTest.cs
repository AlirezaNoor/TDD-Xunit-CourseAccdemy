using Domain.Course;
using DomianTest.Builder;
using FluentAssertions;
using Infrastructrue.Course;
using NSubstitute;
using ServicesCourse;
using Xunit;

namespace SevicesTest;

public class CousreServiceTest
{
    [Fact]
    public void Check_Create_call_in_CourseRepository()
    {
        var command = new CourseDto()
        {
            Id = 13,
            Name = "alireza",
            Tution = 100,
            IsOnilne = true,
        };

        var CourseRepository = Substitute.For<ICouresRepository>();
        var courseService = new CourseService(CourseRepository);
        courseService.Create(command);
        CourseRepository.ReceivedWithAnyArgs().Create(default);
    }

    [Fact]
    public void Check_Craete_Method_return_Currect_Id()
    {
        var command = new CourseDto()
        {
            Id = 13,
            Name = "alireza",
            Tution = 100,
            IsOnilne = true,
        };
        var courseRepository = Substitute.For<ICouresRepository>();
        var CourseServices = new CourseService(courseRepository);


        var id = CourseServices.Create(command);
        id.Should().Be(command.Id);
    }

    [Fact]
    // public void Check_Create_Method_return_null()
    // {
    //     var command = new CourseDto()
    //     {
    //         Id = 13,
    //         Name = "alireza",
    //         Tution = 100,
    //         IsOnilne = true,
    //     };
    //     var coursRepository = Substitute.For<ICouresRepository>();
    //     var CourseServices = new CourseService(coursRepository);
    //     var courseBuilderTest = new CourseBuilderTest();
    //     var course = courseBuilderTest.build();
    //     // coursRepository.getbyname(Arg.Any<Course>()).Returns(course);
    //     Action result = () => CourseServices.Create(command);
    //
    //     result.Should().Throw<Exception>();
    // }
}