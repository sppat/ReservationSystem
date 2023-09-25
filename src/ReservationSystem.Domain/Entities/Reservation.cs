using ReservationSystem.Domain.ValueObjects;

namespace ReservationSystem.Domain.Entities
{
    public class Reservation
    {
        public ReservationId Id { get; init; }
        public ReservationDate ReservationDate { get; private set; }
        public NumberOfCustomers NumberOfCustomers { get; set; }

        public Reservation(ReservationId id, ReservationDate reservationDate, NumberOfCustomers numberOfCustomers)
        {
            Id = id;
            ReservationDate = reservationDate;
            NumberOfCustomers = numberOfCustomers;
        }
    }
}
