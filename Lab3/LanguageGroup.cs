using System.Collections.Generic;

namespace Lab3
{
    public class LanguageGroup
    {
        public Language Language { get; set; }

        public List<Student> Students { get; } = new List<Student>();
    }
}