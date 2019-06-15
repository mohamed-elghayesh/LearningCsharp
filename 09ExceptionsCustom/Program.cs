using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09ExceptionsCustom
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() : base("Invalid user name.")
        {
            
        }

        public InvalidStudentNameException(string message) : base(message)
        {
            
        }

        public InvalidStudentNameException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "James007";

                ValidateStudent(newStudent);
            }
            catch(InvalidStudentNameException isne)
            {
                Console.WriteLine($"The message: {isne.Message}");
            }

            Console.ReadLine();
        }

        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
            {
                throw new InvalidStudentNameException();
            }
                
        }
    }
}
