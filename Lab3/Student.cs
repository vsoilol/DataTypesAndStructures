using System;
using Lab3.Extensions;

namespace Lab3
{
    public class Student
    {
        public string Surname { get; set; }
        
        public bool IsNeedStudentResidence { get; set; }
        
        public TimeSpan ServiceLength { get; set; }
        
        public string FinishedInstitution { get; set; }
        
        public Language LanguageStudy { get; set; }

        public override string ToString()
        {
            return $"Фамилия: {Surname}\n" +
                   $"Нуждается ли в общежитии: {(IsNeedStudentResidence ? "Да" : "Нет")}\n" +
                   $"Стаж работы: {ServiceLength.GetCustomTimeFormat()}\n" +
                   $"Окончил: {FinishedInstitution}\n" +
                   $"Изучал язык: {LanguageStudy.GetLocalizedString()}\n";
        }
    }
}