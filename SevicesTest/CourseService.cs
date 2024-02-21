using Domain.Course;
using Infrastructrue.Course;

namespace SevicesTest;

public class CourseService
{
    private readonly ICouresRepository _couresRepository;

    public CourseService(ICouresRepository couresRepository)
    {
        _couresRepository = couresRepository;
    }


    public int Create(CourseDto command)
    {
      _couresRepository.Create(new Course(command.Id,command.Name,command.IsOnilne,command.Tution));
      return command.Id;
    }
}