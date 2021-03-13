using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDataNugetProject
{
    struct Subject
    {
        public string Name;

        public string SubjectCode;
    }

    class SubjectInfo
    {
        public static List<Subject> subjects = new List<Subject>();
        public static void SubAddData()
        {
            Console.WriteLine("Enter subject name:"); 
            string nme = Console.ReadLine();
            Console.WriteLine("Enter subject code:");
            string subcode = Console.ReadLine();
            Subject sub1;
            sub1.Name = nme;
            sub1.SubjectCode = subcode;
            subjects.Add(sub1);
        }

        public static List<Subject> getSubList()
        {
            return subjects;
        }
    }

}
