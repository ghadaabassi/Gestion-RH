using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Employe : Personnel
    {
        public decimal expr;
        public int chef;
        public string techno;
        public Employe(decimal expr,int chef,string techno,int id, decimal salaire, DateTime date) : base(id, salaire, date)
        {
            this.expr = expr;
            this.chef = chef;
            this.techno = techno;
        }
    }
}
