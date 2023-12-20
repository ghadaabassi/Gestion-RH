using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   
    public class RH : IRH
    {
        public List<Personnel> personnes;
        public string nom;
        public RH(string nom , List<Personnel> personnes)
        {
            this.nom = nom;
           this.personnes = personnes;
        }



        public string ajouterEmpl(Personnel emp)
        {
            try
            {
                personnes.Add(emp);
            }
            catch (Exception ex) { }
            return "Somthing went wrong";
        }


        public Personnel findEmpl(int id)
        {
            foreach (Personnel emp in personnes)
            {
                if (emp.id == id)
                {
                    return emp;
                }
            }
            return null;
        }

        public List<Personnel> findEmplType(IRH.type t)
        {
            List<Personnel> pr = new List<Personnel>();
            foreach (Personnel emp in personnes)
            {
                if (emp.GetType().Name.ToString().Equals(t.ToString()))
                {
                    pr.Add(emp);
                    
                }
            }
            return pr;
        }

        public string deleteEmpl(int id)
        {

            if (findEmpl(id) != null)
            {
                personnes.Remove(findEmpl(id));
                return "Deleted !";
            }

            return "Somthing went wrong";
        }


  

}
}
