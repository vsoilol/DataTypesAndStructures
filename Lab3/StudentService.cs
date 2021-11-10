using System;
using System.Collections.Generic;

namespace Lab3
{
    public class StudentService
    {
        public IEnumerable<Student> GetStudentsByLanguage(IEnumerable<Student> students, Language language)
        {
            var studentsByLanguage = new List<Student>();

            foreach (var student in students)
            {
                if (student.LanguageStudy == language)
                {
                    studentsByLanguage.Add(student);
                }
            }

            return studentsByLanguage;
        }

        public string GetStudentsInformation(IEnumerable<Student> students)
        {
            var info = "";
            foreach (var student in students)
            {
                info += student + "\n";
            }

            return info;
        }
    }
}