using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    public class LanguageGroupService
    {
        public IEnumerable<LanguageGroup> GetLanguageGroupsByStudents(List<Student> students)
        {
            var languageGroups = new List<LanguageGroup>();

            foreach (var student in students)
            {
                var languageGroup = GetLanguageGroupByLanguage(languageGroups, student.LanguageStudy);

                if (languageGroup == null)
                {
                    languageGroup = new LanguageGroup();
                    languageGroup.Language = student.LanguageStudy;
                    languageGroups.Add(languageGroup);
                }

                languageGroup.Students.Add(student);
            }

            return languageGroups;
        }

        private LanguageGroup GetLanguageGroupByLanguage(IEnumerable<LanguageGroup> languageGroups, Language language)
        {
            foreach (var languageGroup in languageGroups)
            {
                if (languageGroup.Language == language)
                {
                    return languageGroup;
                }
            }

            return null;
        }
    }
}