﻿using Domain.Course;
using DomianTest.Builder;
using FluentAssertions;
using Infrastructrue.Course;
using NSubstitute;
using ServicesCourse;
using Xunit;

namespace SevicesTest;

public class CousreServiceTest
{
    private readonly ICouresRepository _couresRepository;
    private readonly CourseService _courseService;

    public CousreServiceTest()
    {
        _couresRepository = Substitute.For<ICouresRepository>();
        _courseService = new CourseService(_couresRepository);
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
        return new CourseDto()
        {
            Id = 13,
            Name = "alireza",
            Tution = 100,
            IsOnilne = true,
        };
    }
}