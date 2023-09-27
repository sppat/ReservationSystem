using ReservationSystem.Domain.Events.Reservation;
using ReservationSystem.Domain.ValueObjects;

namespace ReservationSystem.Domain.Aggregates
{
    public class Reservation : AggregateRoot
    {
        public ReservationId Id { get; init; }
        public ReservationDate ReservationDate { get; private set; }
        public NumberOfCustomers NumberOfCustomers { get; private set; }
        public UserId OwnerId { get; private set; }

        private Reservation(ReservationId id, ReservationDate reservationDate, NumberOfCustomers numberOfCustomers, UserId ownerId)
        {
            Id = id;
            ReservationDate = reservationDate;
            NumberOfCustomers = numberOfCustomers;
            OwnerId = ownerId;
        }

        public static Reservation Create(
            ReservationId id,
            ReservationDate reservationDate,
            NumberOfCustomers numberOfCustomers,
            UserId ownerId)
        {
            var reservation = new Reservation(id, reservationDate, numberOfCustomers, ownerId);

            reservation.AddEvent(new ReservationCreatedEvent());

            return reservation;
        }
    }
}
