using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystemApp
{
    public class Ticket
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public virtual User User { get; set; }
        public virtual Film Film { get; set; }
        public virtual Place Place { get; set; }

  

        public double CalculatePrice()
        {
            
            Price = 40;
            Price -= User.Discount;
            return Price;
        }
        
        public void PrintTicket()
        {
            Console.WriteLine("Name: " + User.Name);
            Console.WriteLine("Film: " + Film.FilmName);
            Console.WriteLine("Row: " + Place.Row);
            Console.WriteLine("Price: " + Price);
        }
        public override string ToString()
        {
            return "Ticket: ";
        }

    }
}
