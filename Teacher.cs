using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDataNugetProject
{
    struct Teacher
    {
        public string Name;

        public string ClassandSection;
    }

    class TeacherInfo
    {
        public static List<Teacher> teachers = new List<Teacher>();
        public static void TeaAddData()
        {
            Console.WriteLine("Enter teacher name:"); 
            string nme = Console.ReadLine();
            Console.WriteLine("Enter teacher Class and Section:");
            string clssndsctn = Console.ReadLine();
            Teacher t1;
            t1.Name = nme;
            t1.ClassandSection = clssndsctn;
            teachers.Add(t1);
        }

        public static List<Teacher> getTeaList()
        {
            return teachers;
        }
    }

}
