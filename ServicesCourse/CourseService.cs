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

    public void Edited(EditCourse command)
    {
        if (_couresRepository.GetBy(command.Id) == null)
        {
            throw new Exception();
        }

        _couresRepository.Delete(command.Id);
        var result = new Course(command.Id, command.Name, command.IsOnilne, command.Tution);
        _couresRepository.Create(result);
    }
}