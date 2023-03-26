using System;
using System.Linq;
using SEDC.AcademyManagement.Domain;
using SEDC.AcademyManagement.Domain.Enums;
using SEDC.AcademyManagement.Domain.Models;

namespace AcademyManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Log In");
                Console.WriteLine("2. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input, please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter your username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Please enter your password:");
                        string password = Console.ReadLine();

                        try
                        {
                            User user = database.Login(username, password);

                            switch (user.Role)
                            {
                                case Role.Admin:
                                    while (true)
                                    {
                                        Console.WriteLine("Please select an option:");
                                        Console.WriteLine("1. Add User");
                                        Console.WriteLine("2. Remove User");
                                        Console.WriteLine("3. Exit");

                                        if (!int.TryParse(Console.ReadLine(), out choice))
                                        {
                                            Console.WriteLine("Invalid input, please try again.");
                                            continue;
                                        }

                                        switch (choice)
                                        {
                                            case 1:
                                                Console.WriteLine("Please enter the new user's username:");
                                                string newUsername = Console.ReadLine();
                                                Console.WriteLine("Please enter the new user's password:");
                                                string newPassword = Console.ReadLine();
                                                Console.WriteLine("Please select the new user's role:");
                                                Console.WriteLine("1. Admin");
                                                Console.WriteLine("2. Trainer");
                                                Console.WriteLine("3. Student");

                                                if (!int.TryParse(Console.ReadLine(), out choice))
                                                {
                                                    Console.WriteLine("Invalid input, please try again.");
                                                    continue;
                                                }

                                                Role role;
                                                switch (choice)
                                                {
                                                    case 1:
                                                        role = Role.Admin;
                                                        break;
                                                    case 2:
                                                        role = Role.Trainer;
                                                        break;
                                                    case 3:
                                                        role = Role.Student;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Invalid input, please try again.");
                                                        continue;
                                                }

                                                database.AddUser(new User { Username = newUsername, Password = newPassword, Role = role });
                                                Console.WriteLine("User added successfully.");
                                                break;
                                            case 2:
                                                Console.WriteLine("Please enter the username of the user you wish to remove:");
                                                string removeUsername = Console.ReadLine();
                                                database.RemoveUser(removeUsername);
                                                Console.WriteLine("User removed successfully.");
                                                break;
                                            case 3:
                                                goto exit;
                                            default:
                                                Console.WriteLine("Invalid input, please try again.");
                                                continue;
                                        }
                                    }
                                case Role.Trainer:
                                    while (true)
                                    {
                                        Console.WriteLine("Please select an option:");
                                        Console.WriteLine("1. View All Students");
                                        Console.WriteLine("2. View All Subjects");
                                        Console.WriteLine("3. Exit");

                                        if (!int.TryParse(Console.ReadLine(), out choice))
                                        {
                                            Console.WriteLine("Invalid input, please try again.");
                                            continue;
                                        }

                                        switch (choice)
                                        {
                                            case 1:
                                                var students = database.GetAllStudents();
                                                foreach (var student in students)
                                                {
                                                    Console.WriteLine(student.FirstName + " " + student.LastName);
                                                }
                                                break;
                                            case 2:
                                                var subjects = database.GetAllSubjects();
                                                foreach (var subject in subjects)
                                                {
                                                    Console.WriteLine(subject.Name + " (" + subject.Students.Count + ")");
                                                }
                                                break;
                                            case 3:
                                                goto exit;


                                            default:
                                                Console.WriteLine("Invalid input, please try again.");
                                                continue;
                                        }
                                    }
                                case Role.Student:
                                    Student student = (Student)user;

                                    Console.WriteLine("Subject: " + student.CurrentSubject.Name);
                                    Console.WriteLine("Grades:");
                                    foreach (var grade in student.Grades)
                                    {
                                        Console.WriteLine(grade.Subject.Name + ": " + grade.Value);
                                    }

                                    break;
                                default:
                                    Console.WriteLine("Invalid user role.");
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }

                        break;
                    case 2:
                        goto exit;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
            }

            exit:
            Console.WriteLine("Exiting application...");
        }
    }
}
