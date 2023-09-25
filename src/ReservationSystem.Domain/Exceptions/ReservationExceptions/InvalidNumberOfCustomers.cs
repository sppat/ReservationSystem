using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Domain.Exceptions.ReservationExceptions
{
    public class InvalidNumberOfCustomers : Exception
    {
        public InvalidNumberOfCustomers(string message) : base(message)
        {
            
        }
    }
}
