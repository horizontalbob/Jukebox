using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
    public static class StringExtensions
    {
        public static bool HasValue(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            if (input == string.Empty) return false;
            return false;
        }
    }
}
