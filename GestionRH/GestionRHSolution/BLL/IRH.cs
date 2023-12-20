using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IRH
    {


        string ajouterEmpl(Personnel emp);

        public Personnel findEmpl(int id);

        public List<Personnel> findEmplType(type t);
        public string deleteEmpl(int id);

        public enum type { Employe, Stagiaire }
    } 
}
