using System.Collections.Generic;

namespace DotnetDeneme1.Models
{
    public static class Repository
    {
        private static List<Student> students = new List<Student>();

        public static List<Student> getStudents
        {
            get
            {
                return students;
            }
            
        }

        public static void addStudent(Student student)
        {
            students.Add(student);
        }

    }
}