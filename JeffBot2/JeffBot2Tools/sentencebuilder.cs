using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeffBot2.Models;

namespace JeffBot2Tools
{
    public static class SentenceBuilder
    {

        /// <summary>
        /// Builds a sentence using the highest supported N-gram level. On missing link at N2, it will terminate.
        /// </summary>
        /// <param name="query">Initial user query.</param>
        /// <returns>Contructed sentence.</returns>
        public static string build(NcDBContext db, string query)
        {
            string subject = Helpers.SubjectFinder.find(query);
            List<string> tokens = new List<string>();
            tokens.Add(subject);
            tokens.Add(findNextToken(db, subject));
            while(tokens.Count < 15)
            {
                string nextToken = findNextToken(db, getLastTokens(tokens, 2));
                if(nextToken == null)
                {
                    break;
                }
                else
                {
                    tokens.Add(nextToken);
                }
            }
            return Helpers.Tokenizer.toString(tokens.ToArray());
        }
        private static string findNextToken(NcDBContext db, string a)
        {
            var ns = from m in db.Ncs select m;
            ns = ns.Where(s => s.A.Equals(a));
            List<Nc> preld = ns.ToList();
            if(preld.Count == 0)
            {
                return null;
            }
            else if(preld.Count == 1)
            {
                return preld[0].B;
            }
            preld.Sort((x, y) => x.Count.CompareTo(y.Count));
            return preld[0].B;
        }
        private static string findNextToken(NcDBContext db, string a, string b)
        {
            var ns = from m in db.Ncs select m;
            ns = ns.Where(s => s.A.Equals(a) && s.B.Equals(b));
            List<Nc> preld = ns.ToList();
            if (preld.Count == 0)
            {
                return null;
            }
            else if (preld.Count == 1)
            {
                return preld[0].C;
            }
            preld.Sort((x, y) => x.Count.CompareTo(y.Count));
            return preld[0].C;
        }
        private static string findNextToken(NcDBContext db, string[] previousTokens)
        {
            return findNextToken(db, previousTokens[0], previousTokens[1]);
        }
        private static string[] getLastTokens(List<string> tokens, int number)
        {
            if(number > tokens.Count)
            {
                throw new Helpers.NotEnoughTokensException();
            }
            else
            {
                List<string> tResult = new List<string>();
                for (int i = tokens.Count - number; i < tokens.Count; i++)
                {
                    tResult.Add(tokens[i]);
                }
                return tResult.ToArray();
            }
        }
    }
}
