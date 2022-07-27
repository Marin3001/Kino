using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystemApp
{
    public class User
    {   
        public int ID { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
        public string UserType { get; set; }

        public User (string Name,string UserType)
        {
            this.Name = Name;
            this.UserType = UserType;
        }
        public double CalculateDiscount()
        {   if (UserType == "Dijete")
                Discount = 20;
            else if (UserType == "Student")
                Discount = 10;
            else if (UserType == "Odrasla Osoba")
                Discount = 0;
            return Discount;
        }
        
        public override string ToString()
        {
            return "Name: " + Name + "UserType:" + UserType + "Discount:" + Discount;
        }
    }
}
