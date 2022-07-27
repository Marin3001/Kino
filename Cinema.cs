using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystemApp
{
    public class Cinema
    {
        public string address;
        public int cinemanumber;
        public int capacity;
       

        public override string ToString()
        {
            return "Cinema: " + cinemanumber + "Address: " + address;
        }
    }
}