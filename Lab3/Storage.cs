using System;
using System.Collections.Generic;

namespace Lab3
{
    public static class Storage
    {
        public static List<Student> GenerateStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Surname = "Surname1",
                    FinishedInstitution = "Institution1",
                    IsNeedStudentResidence = false,
                    LanguageStudy = Language.English,
                    ServiceLength = new TimeSpan(365, 0, 0, 0),
                },
                new Student
                {
                    Surname = "Surname2",
                    FinishedInstitution = "Institution2",
                    IsNeedStudentResidence = true,
                    LanguageStudy = Language.Chinese,
                    ServiceLength = new TimeSpan(365, 0, 0, 0),
                },
                new Student
                {
                    Surname = "Surname3",
                    FinishedInstitution = "Institution3",
                    IsNeedStudentResidence = false,
                    LanguageStudy = Language.Japanese,
                    ServiceLength = new TimeSpan(365, 0, 0, 0),
                },
                new Student
                {
                    Surname = "Surname4",
                    FinishedInstitution = "Institution4",
                    IsNeedStudentResidence = false,
                    LanguageStudy = Language.English,
                    ServiceLength = new TimeSpan(365, 0, 0, 0),
                },
                new Student
                {
                    Surname = "Surname5",
                    FinishedInstitution = "Institution5",
                    IsNeedStudentResidence = true,
                    LanguageStudy = Language.Ukrainian,
                    ServiceLength = new TimeSpan(365, 0, 0, 0),
                },
                new Student
                {
                    Surname = "Surname6",
                    FinishedInstitution = "Institution6",
                    IsNeedStudentResidence = false,
                    LanguageStudy = Language.Ukrainian,
                    ServiceLength = new TimeSpan(365, 0, 0, 0),
                },
                new Student
                {
                    Surname = "Surname7",
                    FinishedInstitution = "Institution7",
                    IsNeedStudentResidence = true,
                    LanguageStudy = Language.Japanese,
                    ServiceLength = new TimeSpan(365, 0, 0, 0),
                },
            };
        }
    }
}