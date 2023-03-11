using HomeWork04Part3.Classes;
        Student[] students = new Student[5];

        students[0] = new Student() { Name = "Dejan", Academy = "SEDC", Group = "G5" };
        students[1] = new Student() { Name = "Tode", Academy = "SEDC", Group = "Ja kidna vo druga grupa" };
        students[2] = new Student() { Name = "Hristina", Academy = "SEDC", Group = "Fizicko prisustvo" };
        students[3] = new Student() { Name = "Ljupche", Academy = "SEDC", Group = "G5" };
        students[4] = new Student() { Name = "Sanja", Academy = "SEDC", Group = "G5" };

        Console.Write("Enter student name: ");
        string searchName = Console.ReadLine();

        Student result = null;

        foreach (Student student in students)
        {
            if (student.Name == searchName)
            {
                result = student;
                break;
            }
        }

        if (result != null)
        {
            Console.WriteLine($"Name: {result.Name}, Academy: {result.Academy}, Group: {result.Group}");
        }
        else
        {
            Console.WriteLine($"Error: no student found with name {searchName}.");
        }