namespace Infrastructrue.Course;

public interface ICouresRepository
{
    int Create(Domain.Course.Course course);


    List<Domain.Course.Course> GetAll();


    Domain.Course.Course GetBy(int i);


    void Delete(int i);
    Domain.Course.Course getbyname(Domain.Course.Course course);
    
}