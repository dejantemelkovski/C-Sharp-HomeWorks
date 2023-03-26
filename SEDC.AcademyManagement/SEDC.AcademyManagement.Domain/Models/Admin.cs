using SEDC.AcademyManagement.Domain.Enums;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class Admin : User
    {
        private string? password;
        private string? fullName;

        public Admin(string? username, string? password, string? fullName)
        {
            Username = username;
            this.password = password;
            this.fullName = fullName;
        }

        public Admin(string username, string firstname, string lastname, int age) : base(username, firstname, lastname, age)
        {
            Role = Role.Admin;
        }

        public void AddUser(Database database, string? username, string? password, string? role)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(Database database, string? username)
        {
            throw new NotImplementedException();
        }

        public void ShowUsers(Database database)
        {
            throw new NotImplementedException();
        }
    }
}
