namespace StudentDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of students to be added: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Student " + (i + 1));
                students[i] = new Student();
                students[i].enrollCourse();
                students[i].payTuitionFee();
                Console.WriteLine(students[i].showStudentInfos());
                Console.WriteLine();
            }
        }
    }
}