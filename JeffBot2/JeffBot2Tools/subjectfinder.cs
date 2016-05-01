using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffBot2Tools
{
    namespace Helpers
    {
        public static class SubjectFinder
        {
            static Random r = new Random();

            public static string find(string query)
            {
                string[] tokens = Tokenizer.split(query);
                return tokens[r.Next(0, tokens.Length)];
            }
        }
    }
}
