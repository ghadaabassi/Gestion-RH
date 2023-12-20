using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Stagiaire : Personnel
    {
        public string pfe;
        public string encadrant;
        public DateTime DateValidite;
        public Stagiaire(string pfe,string encadrant,DateTime DateValidie,int id, decimal salaire, DateTime date) : base(id, salaire, date)
        {
            this.pfe = pfe;
            this.encadrant = encadrant;
            this.DateValidite = DateValidie;
        }
    }
}
