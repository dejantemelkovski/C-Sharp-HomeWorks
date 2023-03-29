using SEDC.AcademyManagement.Domain.Enums;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class User
    {
        private string v1;
        private string v2;
        private int v3;

        public User(string username, string v1, string v2, int v3)
        {
            Username = username;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public User(string username, string firstname, string lastname, string? lastName, int age)
        {
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }
        public string Password { get; set; }
    }
}
