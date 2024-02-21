using FluentAssertions;
using Infrastructrue.Course;
using NSubstitute;
using Xunit;

namespace SevicesTest;

public class CousreServiceTest
{
    [Fact]
    public void Check_Create_call_in_CourseRepository()
    {
       var command= new CourseDto()
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
        var command= new CourseDto()
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
}