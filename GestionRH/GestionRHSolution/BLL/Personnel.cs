namespace BLL
{
    public class Personnel
    {
        public int id { get; set; }
        public decimal salaire { get; set; }

        public DateTime date { get; set; }

        public Personnel(int id, decimal salaire, DateTime date)
        {
            this.id = id;
            this.salaire = salaire;
            this.date = date;

        }
    }


    }