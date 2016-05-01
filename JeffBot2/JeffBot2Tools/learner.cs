using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeffBot2.Models;
using System.Data.Entity;

namespace JeffBot2Tools
{
    public static class Learner
    {
        public static void commit(NcDBContext db, List<string[]> queries)
        {
            foreach (string[] i in queries)
            {
                commit(db, i);
            }
        }
        public static void commit(NcDBContext db, string[] query)
        {
            var ns = from m in db.Ncs select m;
            // Somehow this fixes certain LINQ errors.
            string qa = query[0];
            string qb = query[1];
            string qc = query[2];
            ns = ns.Where(s => s.A.Equals(qa) && s.B.Equals(qb) && s.C.Equals(qc));
            List<Nc> preld = ns.ToList();
            if(preld.Count < 1)
            {
                Nc n = new Nc();
                n.A = qa;
                n.B = qb;
                n.C = qc;
                n.Count = 1;
                db.Ncs.Add(n);
                db.SaveChanges();
            }
            else
            {
                preld[0].Count += 1;
                db.Entry(preld[0]).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
