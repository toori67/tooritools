using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

using System.Globalization;
using ChefManager.Resources.language;
namespace ChefManager.Controller
{
    public class LanguageDataManager
    {
        public static void SetLanguage(CultureInfo culture)
        {
            MenuAndDesc.Culture = culture;
        }
    }

    public struct Languages
    {
        public const string KOREAN = "한국어";
        public const string ENGLISH = "English";

        public static string[] GetByArray()
        {
            return new string[] { KOREAN, ENGLISH };
        }

        public static CultureInfo GetLanguageCulture(string lang)
        {
            switch (lang)
            {
                case KOREAN:
                    return new CultureInfo("ko-KR");

                case ENGLISH:
                    return new CultureInfo("en-US");

            }
            throw new InvalidOperationException();
        }
    }
}