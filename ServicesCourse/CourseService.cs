using Domain.Course;
using Infrastructrue.Course;

namespace ServicesCourse;

public class CourseService
{
    private readonly ICouresRepository _couresRepository;

    public CourseService(ICouresRepository couresRepository)
    {
        _couresRepository = couresRepository;
    }


    public int Create(CourseDto command)
    {
        var result = new Course(command.Id, command.Name, command.IsOnilne, command.Tution);
        // if (_couresRepository.getbyname(result) == null)
        // {
        //     throw new Exception();
        // }

        _couresRepository.Create(result);
        return command.Id;
    }
}