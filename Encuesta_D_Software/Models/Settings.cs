using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta_D_Software.Models
{
    public class Settings
    {
        public static bool IsAuthenticated 
        {
            get => Preferences.Default.Get(nameof(IsAuthenticated), false);
            set => Preferences.Default.Set(nameof(IsAuthenticated), value);
        }

        public static string Email
        {
            get => Preferences.Default.Get(nameof(Email), string.Empty);
            set => Preferences.Default.Set(nameof(Email), value);
        }

        public static string question1registration
        {
            get => Preferences.Default.Get(nameof(question1registration), string.Empty);
            set => Preferences.Default.Set(nameof(question1registration), value);
        }

        public static string question2restration
        {
            get => Preferences.Default.Get(nameof(question2restration), string.Empty);
            set => Preferences.Default.Set(nameof(question2restration), value);
        }
        public static string question3restration
        {
            get => Preferences.Default.Get(nameof(question3restration), string.Empty);
            set => Preferences.Default.Set(nameof(question3restration), value);
        }
    }
}
