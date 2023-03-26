using SEDC.AcademyManagement.Domain.Enums;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class Trainer : User
    {
        private string? password;
        private string? fullName;

        public Trainer(string? username, string? password, string? fullName)
        {
            Username = username;
            this.password = password;
            this.fullName = fullName;
        }

        public Trainer(string username, string firstname, string lastname, int age) : base(username, firstname, lastname, age)
        {
            Role = Role.Trainer;
        }

        public void SeeAllStudents(Database database)
        {
            throw new NotImplementedException();
        }

        public void SeeAllSubjects(Database database)
        {
            throw new NotImplementedException();
        }
    }
}
