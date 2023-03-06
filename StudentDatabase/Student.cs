using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int studentClass;
        private string studentID = "";
        private string courses = "";
        private int tuitionFee = 0;
        private int courseFee = 500;

        public Student() 
        {
            try
            {
                Console.Write("First Name: ");
                this.firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                this.lastName = Console.ReadLine();

                Console.WriteLine();

                printClasses();
                this.studentClass = int.Parse(Console.ReadLine());

                setStudentID();
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public Student(string firstName, string lastName, int studentClass, string studentID, string courses, int tuitionFee, int courseFee)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentClass = studentClass;
            this.studentID = studentID;
            this.courses = courses;
            this.tuitionFee = tuitionFee;
            this.courseFee = courseFee;
        }

        private void printClasses()
        {
            Console.WriteLine("1 - Freshmen");
            Console.WriteLine("2 - Sophmore");
            Console.WriteLine("3 - Junior");
            Console.WriteLine("4 - Senior");
            Console.Write("Enter the student's class: ");
        }

        private string getStudentID()
        {
            return studentID;
        }

        private void setStudentID()
        {
            this.studentID += this.studentClass;

            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                this.studentID += rnd.Next(0, 10);
            }
        }

        private void viewTuitionFee()
        {
            Console.WriteLine("Total Tuition Fee: " + this.tuitionFee);
        }

        public void payTuitionFee()
        {
            try
            {
                viewTuitionFee();
                Console.Write("Amount you want to pay: ");
                int amount = int.Parse(Console.ReadLine());
                this.tuitionFee = this.tuitionFee - amount;
                Console.WriteLine("Amount paid: " + amount);
                Console.WriteLine("Current Tuition Fee: " + this.tuitionFee);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public void enrollCourse()
        {
            string[] courses101 = { "History 101" , "Mathematics 101" , "English 101" , "Chemistry 101" , "Computer Science 101" };

            Console.WriteLine();

            foreach (string i in courses101)
            {
                Console.WriteLine("Course Fee: 500 TL - " + i);
            }

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Add the courses you want to attend");
                Console.WriteLine("Press Q to exit");

                string course = Console.ReadLine();

                if (course == "Q" || course == "q")
                {
                    Console.WriteLine();
                    Console.WriteLine("Returning to menu...");
                    Console.WriteLine();
                    break;
                }

                else
                {
                    this.courses = this.courses + " " + course;
                    this.tuitionFee += this.courseFee;
                }
            }
        }

        public string showStudentInfos()
        {
            return 
                  "First Name: " + firstName + "\n" + 
                  "Last Name: " + lastName + "\n" + 
                  "Student Class: " + studentClass + "\n" + 
                  "Student ID: " + studentID + "\n" + 
                  "Courses: " + courses + "\n" + 
                  "Total Tuition Fee: " + tuitionFee;
        }
    }
}
