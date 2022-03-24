using System;
using ExercicioExcecoes.Entities.Exceptions;

namespace ExercicioExcecoes.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get;private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation()
        {

        }
        public Reservation(int roomnumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in");
            }

            RoomNumber = roomnumber;
            CheckIn = checkin;
            CheckOut = checkout;

        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException( "Error in reservation: Reservation dates for update must be future dates");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in");
            }

            CheckIn = checkin;
            CheckOut = checkout;
            
        }
        public override string ToString()
        {
            return "Room"
                +RoomNumber
                +", check-in: "
                +CheckIn.ToString("dd/MM/yyyy")
                +", check-out: "
                +CheckOut.ToString("dd/MM/yyyy")
                +", "
                +Duration()
                +" nights";
        }

    }
}
