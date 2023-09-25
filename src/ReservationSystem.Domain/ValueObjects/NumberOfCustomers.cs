using ReservationSystem.Domain.Exceptions.ReservationExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Domain.ValueObjects
{
    public record NumberOfCustomers
    {
        public int Value { get; init; }

        public NumberOfCustomers(int numberOfCustomers)
        {
            if (numberOfCustomers <= 0)
            {
                throw new InvalidNumberOfCustomers("Customers must be positive number");
            }

            Value = numberOfCustomers;
        }

        public static implicit operator NumberOfCustomers(int numberOfCustomers) => new(numberOfCustomers);
        public static implicit operator int(NumberOfCustomers numberOfCustomer) => numberOfCustomer.Value;
    }
}
