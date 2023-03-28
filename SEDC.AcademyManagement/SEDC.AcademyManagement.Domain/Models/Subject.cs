namespace SEDC.AcademyManagement.Domain.Models
{
    public class Subject
    {
        public List<Student> StudentsEnrolled { get; set; } = new List<Student>();
        public Subject(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
