using Domain.Course;

namespace ServicesCourse;

public interface ICourseService
{
    int Create(CourseDto command);
    void Edited(EditCourse command);
    void Delete(int id);
    List<Course> GetAll();
}