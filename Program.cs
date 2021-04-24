using System;
using System.Collections.Generic;

namespace projectStudent
{
    class student
    {
        public string name;
        public int grade;
        
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<student> NamesId = new List<student>();
            string choice = "yes";

            while (choice == "yes")
            {

                student s = new student();
                Console.WriteLine("Enter the student's name : ");
                s.name = Console.ReadLine();
                Console.WriteLine("Enter the student's grade" );
                s.grade = Convert.ToInt32(Console.ReadLine());
                NamesId.Add(s);

                Console.WriteLine("add another student? yes / no");
                choice = (Console.ReadLine()).ToLower();
                if (choice != "yes" && choice != "no")
                {
                    Console.WriteLine("invalid data please answer with yes or no /n add another student? yes/ no");
                    choice = (Console.ReadLine()).ToLower();

                }


            }

            foreach (var item in NamesId)
            {
                Console.WriteLine($"Student's name is {item.name} , and his grade is : {item.grade}");
            }

            Console.WriteLine("Enter a Grade to search how many students got it :");
            int gradeCheck = Convert.ToInt32(Console.ReadLine());
            
             sGradeCheck( NamesId, gradeCheck);

        }
        public static void sGradeCheck( List<student> NamesId, int gradeCheck)
        {
            int count = 0;
            foreach (var item in NamesId)
            {
                if (item.grade == gradeCheck)
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of Student with grade {gradeCheck} is : {count}");
        }
    }

}
