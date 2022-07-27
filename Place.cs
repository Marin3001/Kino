using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystemApp
{
    public class Place : Cinema
    {
        public int Row { get; set; }    
        public int Number { get; set; }

        public int ID { get; set; }


        public Place (string address, int cinemanumber, int capacity, int Row, int Number)
        {
            this.address = address;
            this.cinemanumber = cinemanumber;
            this.capacity = capacity;
            this.Row = Row;
            this.Number = Number;
        }
        
        public void Print()
        {   if (Number > Row)
                Console.WriteLine("Row is full");
            else
                Console.WriteLine("Choice is succesfull");
        }

        public override string ToString()
        {
            return "Row number:" + Row;
        }
    }
}
