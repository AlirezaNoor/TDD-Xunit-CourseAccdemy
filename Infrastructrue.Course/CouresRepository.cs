namespace Infrastructrue.Course;

public class CouresRepository : ICouresRepository
{
    private readonly Acddemy _acddemy;

    public CouresRepository(Acddemy acddemy)
    {
        _acddemy = acddemy;
    }

    public int Create(Domain.Course.Course course)
    {
        _acddemy.courses.Add(course);
        _acddemy.SaveChanges();
        return course.Id;
    }

    public List<Domain.Course.Course> GetAll()
    {
        return _acddemy.courses.ToList();
    }

    public Domain.Course.Course GetBy(int i)
    {
        return null;
    }

    public void Delete(int i)
    {
    }

    public Domain.Course.Course getbyname(Domain.Course.Course course)
    {
        return null;
    }
}