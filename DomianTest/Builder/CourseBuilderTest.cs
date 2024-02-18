using Domain.Course;

namespace DomianTest.Builder;

public class CourseBuilderTest
{
    int id = 1;
     string name = "Abdollah";
     bool isonilne = true;
     double tution = 1000;

     public CourseBuilderTest checked_name_is_null(string name)
     {
         this.name = name;
         return this ;
     }

     public CourseBuilderTest checked_name_is_Not_Equal_or_Lass(double tution)
     {
         this.tution = tution;
         return this ;
     }
    public Course build()
    {
        return new Course(id, name, isonilne, tution);
    }
}