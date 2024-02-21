namespace Infrastructrue.Course;

public class CouresRepository:ICouresRepository
{
    public List<Domain.Course.Course> Courses = new List<Domain.Course.Course>()
    {
        new Domain.Course.Course(30,"alireza",true,870)
    };

    public void Create(Domain.Course.Course course)
    {
        Courses.Add(course);
    }

    public List<Domain.Course.Course> GetAll()
    {
        return Courses;
    }

    public Domain.Course.Course GetBy(int i)
    {
        return Courses.FirstOrDefault(x => x.Id == i);
    }

    public void Delete(int i)
    {
        var cours = GetBy(i);
        Courses.Remove(cours);
    }

    public Domain.Course.Course getbyname(Domain.Course.Course course)
    {
        return Courses.FirstOrDefault(x => x.Name == course.Name);
    }
}