using Domain.Course;
using DomianTest.Builder;
using FluentAssertions;
using Xunit;

namespace DomianTest;

public class Coursetest
{
    [Fact]
    public void Check_Constructor_IsSucces()
    {
        const int id = 1;
        const string name = "Abdollah";
        const bool isonilne = true;
        const double tution = 1000;
        CourseBuilderTest courseBuilderTest = new();
        var course = courseBuilderTest.build();
        course.Id.Should().Be(id);
        course.Name.Should().Be(name);
        course.IsOnilne.Should().Be(isonilne);
        course.Tution.Should().Be(tution);
        course.selctions.Should().BeEmpty();
    }

    [Fact]
    public void Check_name_if_when_pass_null_value_then_throw_excption()
    {
        CourseBuilderTest courseBuilderTest = new();
        Action test = () => courseBuilderTest.checked_name_is_null("").build();
        test.Should().Throw<Exception>();
    }

    [Fact]
    public void Chacked_tution_If_Equal_or_Less_then_0()
    {
        CourseBuilderTest courseBuilderTest = new();
        Action test = () => courseBuilderTest.checked_name_is_Not_Equal_or_Lass(0).build();
        test.Should().Throw<Exception>();
    }

    [Fact]
    public void AddAction_When_pass_ID_Name_to()
    {
        CourseBuilderTest courseBuilderTest = new();
        var course = courseBuilderTest.build();
        int id = 1;
        string name = "ALireza";
        section sction = new section(id, name);
        course.AddAction(sction);

        course.selctions.Should().ContainEquivalentOf(sction);
    }
}