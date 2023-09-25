using ReservationSystem.Domain.Exceptions.ReservationExceptions;

namespace ReservationSystem.Domain.ValueObjects
{
    public record ReservationDate
    {
        public DateTimeOffset Value { get; init; }

        public ReservationDate(DateTimeOffset reservationDate)
        {
            if (reservationDate < DateTimeOffset.UtcNow)
            {
                throw new InvalidReservationDate("Cannot make a reservation in the past.");
            }

            Value = reservationDate;
        }

        public static implicit operator DateTimeOffset(ReservationDate reservationDate) => reservationDate.Value;
        public static implicit operator ReservationDate(DateTimeOffset reservationDate) => new(reservationDate);
    }
}
