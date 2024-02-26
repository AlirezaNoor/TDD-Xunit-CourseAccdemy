using CoursePresentian.Controllers;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
using ServicesCourse;

namespace PresentianTest;

public class presentaionTest
{
    [Fact]
    public void Check_controller_Pass_all()
    {
        var inject = NSubstitute.Substitute.For<ICourseService>();
        var controller=new CoursessController(inject);
        controller.test();
        inject.Received().GetAll();
    }
}