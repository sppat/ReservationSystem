using ReservationSystem.Domain.Exceptions.ReservationExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Domain.ValueObjects
{
    public record UserId
    {
        public Guid Value { get; private set; }

        public UserId(Guid value)
        {
            if (value ==  Guid.Empty) 
            {
                throw new EmptyUserIdException();
            }

            Value = value;
        }

        public static implicit operator Guid(UserId value) => value.Value;
        public static implicit operator UserId(Guid value) => new(value);
    }
}
