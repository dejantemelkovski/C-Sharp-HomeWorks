using SEDC.AcademyManagement.Domain.Enums;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class Trainer : User
    {
        private string? password;
        private string? fullName;

        public Trainer(string username, string firstname, string lastname, int age, string password, string fullName) : base(username, firstname, lastname, age)
        {
            Role = Role.Trainer;
            Password = password;
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