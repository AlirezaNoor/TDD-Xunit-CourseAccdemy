using Domain.Course;
using FluentAssertions;
using Xunit;

namespace DomianTest;

public class SelctionTest
{
   [Fact]
   public void Check_Constructor_IsCompleted()
   {
      int id = 1;
      string name = "section";
      section section = new section(id,name);
      section.Id.Should().Be(id);
      section.Name.Should().Be(name);
   }
     
}
