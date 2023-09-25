namespace ReservationSystem.Domain.Exceptions.ReservationExceptions
{
    public class InvalidReservationDate : Exception
    {
        public InvalidReservationDate(string message) : base(message)
        {

        }
    }
}
