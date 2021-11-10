using System;
using System.Text;
using Lab3.Extensions;

namespace Lab3
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var languageGroupService = new LanguageGroupService();
            var studentService = new StudentService();
            var students = Storage.GenerateStudents();

            Console.WriteLine("Все студенты:");
            Console.WriteLine(studentService.GetStudentsInformation(students));

            var languageGroups = languageGroupService.GetLanguageGroupsByStudents(students);

            Console.WriteLine("Группы языков\n");
            foreach (var languageGroup in languageGroups)
            {
                Console.WriteLine($"Группа {languageGroup.Language.GetLocalizedString()}:");
                Console.WriteLine(studentService.GetStudentsInformation(languageGroup.Students));
            }

            var studentsByEnglishLanguage = studentService
                .GetStudentsByLanguage(students, Language.English);

            Console.WriteLine("Студенты изучающие английский:\n");
            Console.WriteLine(studentService.GetStudentsInformation(studentsByEnglishLanguage));
        }
    }
}