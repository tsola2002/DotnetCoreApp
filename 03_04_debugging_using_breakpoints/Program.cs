﻿using System;
using System.Collections.Generic;
using System.Text; 

namespace _03_03_custom_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // we call our import function to see dat student data was imported
            Import();

            // we a student list and we make of type student
            var students = new List<Student>(); 

            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            var adding = true;

            while(adding)
            {
                // adding a try/catch block
                try
                {
                     // we create a new object instance of type student
                    var newStudent = new Student();



                    // Console.Write("Student Name: ");
                    // newStudent.Name = (Console.ReadLine());

                    // refactored the above code to Util class function
                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    // divide by zero code to test other exception
                    //var z = 0;
                    //var a = 1 / z;

                    // refactored the above code to Util class function
                    // it's also refactored with exceptions to use tryparse
                    //the out parameter will give us the result
                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                    // refactored the above code to Util class functionde
                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                // refactored the above code to Util class function
                    newStudent.Address = Util.Console.Ask("Student Address: ");


                    //refactored the code above to use the new traditional variable
                    newStudent.Phone = Util.Console.AskInt("Student Phone Number: ");

                    students.Add(newStudent);

                    // accessing the static variable through the class
                    Student.Count++;

                    // we output the student count for testing
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                    
                }

                // this exception has to come before the more generic ones
                // we receive the message from console class
                catch (FormatException msg)
                {
                    // this error message displays if letter is typed in where number is supposed to be
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    // this error message displays if the program fails
                    Console.WriteLine("Error Adding Student please try again");
                }
                

               
            }
        }
    
        static void Import()
        {
           var importedStudent = new Student("Jenny", 86, "december 9", "Lekki", 123456);

           //test to see dat the import is working
           Console.WriteLine(importedStudent.Name);
        }
    }

    // this class will unify & abstract the concepts off student & teacher
    class Member
    {
        public string Name;
        public string Address;
        // the protected keyword is like private but it only works with inheritance
        protected int phone;

        //creating a traditional c-sharp property
        public int Phone {
            set 
            {
                 phone = value; 
                 
                 //Console.WriteLine(phone);
                 
                 // test the functionality & output the traditional property
                 //Console.WriteLine(phone); 
            }
        }
    }

    //this syntax represents inheritance which means student is inheriting member class
    class Student : Member
    { 
        // creating a static variable
        //static fields are not associated with object instance
        static public int Count = 0;
        public int Grade;
        public string Birthday;
        

        // we create an empty constructor
        public Student()
        {

        }

        //the constructor requires parameters so we cant pass empty constructors
        // a constructor usually uses the same name as the class name
        // a contructor will run as soon as the object is created or constructed
        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }

        
    }

    class Teacher : Member
    { 
        public string Subject;

    }

}
