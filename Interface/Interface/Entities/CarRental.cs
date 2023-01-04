using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime star, DateTime finish, Vehicle vehicle)
        {
            Start = star;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
