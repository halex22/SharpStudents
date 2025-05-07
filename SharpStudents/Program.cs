namespace SharpStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new() { 
                Name = "Student A",
                Surname = "Surname A",
                Gender = "Peanut",
                Yob = 600,
                Marks = [10, 8, 6, 3]
            };

            Student s2 = new()
            {
                Name = "Student B",
                Surname = "Surname B",
                Gender = "Male",
                Yob = 2000,
                Marks = [9, 8, 5, 6]
            };

            Student s3 = new()
            {
                Name = "Student C",
                Surname = "Surname C",
                Gender = "Female",
                Yob = 2001,
                Marks = [10, 9, 8, 7]
            };

            List<Student> studentList = [s1, s2, s3];   

            foreach (Student student in studentList)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine(student.Mean);
            }

            double classMean = studentList.Average(s => s.Mean);
            Console.WriteLine($"all students mean: {classMean.ToString()}");

            Teacher teacher = new() { Name = "Joe", Subject = "Cooking", Students = studentList };
            Console.WriteLine(teacher.ToString());    

        }
    }
}
