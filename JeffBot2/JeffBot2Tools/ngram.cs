using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffBot2Tools
{
    namespace Helpers
    {
        public static class Ngram
        {
            public static List<string[]> split(int pairLength, string query)
            {
                string[] tokens = Tokenizer.split(query);
                if(tokens.Length < pairLength)
                {
                    throw new NotEnoughTokensException();
                }
                List<string[]> results = new List<string[]>();
                for(int i = 0; i <= tokens.Length - pairLength; i++)
                {
                    List<string> localTokens = new List<string>();
                    for(int j = 0; j < pairLength; j++)
                    {
                        localTokens.Add(tokens[i + j]);
                    }
                    results.Add(localTokens.ToArray());
                }
                return results;
            }
        }
        public class NotEnoughTokensException : Exception
        {

        }
    }
}
