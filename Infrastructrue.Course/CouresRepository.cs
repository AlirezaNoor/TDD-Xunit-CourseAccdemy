namespace Infrastructrue.Course;

public class CouresRepository : ICouresRepository
{
    private readonly Acddemy _acddemy;

    public CouresRepository(Acddemy acddemy)
    {
        _acddemy = acddemy;
    }

    public void Create(Domain.Course.Course course)
    {
        _acddemy.Courses.Add(course);
        _acddemy.SaveChanges();
    }

    public List<Domain.Course.Course> GetAll()
    {
        return _acddemy.Courses.ToList();
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