﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException(string name)
        {
            Console.WriteLine("Invalid Student Name: {0}", name);
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
            catch {}
            
            Console.ReadLine();
        }

        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);
        }
    }
}
