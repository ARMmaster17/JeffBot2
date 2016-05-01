using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace JeffBot2Tools
{
    namespace Helpers
    {
        public static class Sanitizer
        {
            public static string clean(string query)
            {
                Regex regex = new Regex("[^a-zA-Z0-9]");
                string result = "";
                foreach (string i in Helpers.Tokenizer.split(query))
                {
                    result = result + regex.Replace(i, "") + " ";
                }
                return result.TrimEnd(' ').ToLower();
            }
        }
    }
}
