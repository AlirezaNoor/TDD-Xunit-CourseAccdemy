namespace Domain.Course;

public class Course
{


    public Course(int id, string abdollah, bool isonilne, double tution)
    {
        NameChecker(abdollah);
        TutionChacekr(tution);
        Id = id;
        Name = abdollah;
        IsOnilne = isonilne;
        Tution = tution;
        selctions = new List<section>();
    }

    private static void TutionChacekr(double tution)
    {
        if (tution <= 0)
        {
            throw new Exception();
        }
    }


    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsOnilne { get; set; }
    public double Tution { get; set; }
    public List<section> selctions { get; set; }
    private static void NameChecker(string abdollah)
    {
        if (string.IsNullOrEmpty(abdollah))
        {
            throw new Exception();
        }
    }

    public void AddAction(section sction)
    {
        selctions.Add(sction);
    }
}

