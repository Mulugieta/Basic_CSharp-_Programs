namespace EFCodeFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDatabaseContext())
            {
                var student = new Student()
                {
                    FirstName = "Mulugieta",
                    LastName = "Elias",
                    DateOfBirth = new DateOnly(2000, 8, 14),
                    Major = "Computer Science",
                    GPA = 3.85f

                };
                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
        }
    }
}
