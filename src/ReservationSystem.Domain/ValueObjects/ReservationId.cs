using ReservationSystem.Domain.Exceptions.ReservationExceptions;

namespace ReservationSystem.Domain.ValueObjects
{
    public record ReservationId
    {
        public Guid Value { get; init; }

        public ReservationId(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new EmptyReservationIdException();
            }

            Value = id;
        }

        public static implicit operator Guid(ReservationId id) => id.Value;
        public static implicit operator ReservationId(Guid id) => new(id);
    }
}
