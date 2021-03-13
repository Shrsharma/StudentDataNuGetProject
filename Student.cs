using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDataNugetProject
{
    struct Student
    {
        public string Name;
        public string ClassAndSection;
       
    }

    
    class StudentInfo
    {
        public static List<Student> students = new List<Student>();
        public static void StudAddData()
        {
            Console.WriteLine("Enter student name:");
            string nme = Console.ReadLine();
            Console.WriteLine("Enter student Class and Section:");
            string clssndsctn = Console.ReadLine();
            Student s1=new Student();
            s1.Name = nme;
            s1.ClassAndSection = clssndsctn;
            students.Add(s1);
           /* 
            foreach(Student ele in students)
            {
                Console.WriteLine("Name:{0}  ||  Class and Section:{1}",ele.Name,ele.ClassAndSection);

            }*/


        }

        public static List<Student> getStudList()
        {
            return students;
        }
    }

}
