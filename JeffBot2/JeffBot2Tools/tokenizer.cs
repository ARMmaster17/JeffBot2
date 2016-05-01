using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffBot2Tools
{
    namespace Helpers
    {
        public static class Tokenizer
        {
            public static string[] split(string query)
            {
                return query.Split(' ');
            }
            public static string toString(string[] tokens)
            {
                string result = "";
                foreach(string i in tokens)
                {
                    result = result + i + " ";
                }
                return result.TrimEnd(' ');
            }
        }
    }
}
