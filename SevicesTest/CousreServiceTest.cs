using Domain.Course;
using DomianTest.Builder;
using FluentAssertions;
using Infrastructrue.Course;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using ServicesCourse;
using Tynamix.ObjectFiller;
using Xunit;

namespace SevicesTest;

public class CousreServiceTest
{
    private readonly ICouresRepository _couresRepository;
    private readonly CourseService _courseService;
    private CourseBuilderTest _courseBuilderTest;

    public CousreServiceTest()
    {
        _couresRepository = Substitute.For<ICouresRepository>();
        _courseService = new CourseService(_couresRepository);
        _courseBuilderTest = new CourseBuilderTest();
    }

    [Fact]
    public void Check_Create_call_in_CourseRepository()
    {
        var command = moqdata();
        _courseService.Create(command);
        _couresRepository.ReceivedWithAnyArgs().Create(default);
    }


    [Fact]
    public void Check_Craete_Method_return_Currect_Id()
    {
        var command = moqdata();


        var id = _courseService.Create(command);
        id.Should().Be(command.Id);
    }

    // [Fact]
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
    private static CourseDto moqdata()
    {
        // return new CourseDto()
        // {
        //     Id = 13,
        //     Name = Faker.Name.FullName(),
        //     Tution = 100,
        //     IsOnilne = true,
        // };

        var filler = new Filler<CourseDto>();
        filler.Setup().OnProperty(x => x.Tution).Use(780);

        return filler.Create();
    }

    [Fact]
    public void Check_edited_inCouries_Services()
    {
        var command = new EditCourse()
        {
            Id = 12,
            IsOnilne = true,
            Name = "Alireza",
            Tution = 890,
        };
        var course = _courseBuilderTest.build();
        _couresRepository.GetBy(command.Id).Returns(course);
        _courseService.Edited(command);

        
        _couresRepository.Received().Delete(command.Id);
        _couresRepository.Received().Create(Arg.Any<Course>());
    }

    [Fact]
    public void Check_edited_inCouries_Services_pass_exption()
    {
        var command = new EditCourse()
        {
            Id = 12,
            IsOnilne = true,
            Name = "Alireza",
            Tution = 890,
        };
        _couresRepository.GetBy(command.Id).ReturnsNull();
        Action action = () => _courseService.Edited(command);
        action.Should().Throw<Exception>();
    }
}