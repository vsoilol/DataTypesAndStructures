using System;

namespace Lab3.Extensions
{
    public static class EnumExtension
    {
        public static string GetLocalizedString(this Language language)
        {
            return language switch
            {
                Language.English => "Английский",
                Language.Ukrainian => "Украинский",
                Language.Chinese => "Китайский",
                Language.Japanese => "Японский",
                _ => throw new NotImplementedException($"{language} is not translated.")
            };
        }
    }
}