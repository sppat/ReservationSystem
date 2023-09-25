namespace ReservationSystem.Domain.Exceptions.ReservationExceptions
{
    public class EmptyReservationIdException : Exception
    {
        public EmptyReservationIdException() : base("Reservation id cannot be empty.")
        {

        }
    }
}
