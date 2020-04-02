using System;
using Framework;

namespace Booking.Domain.Values
{
    public class BookingEnd : Value<BookingEnd>
    {
        private DateTime _bookingEnd;


        private BookingEnd(DateTime bookingEnd)
        {
            if (bookingEnd == default)
                throw new ArgumentException(
                    "Booking slut dato/tid skal være sat",
                    nameof(bookingEnd));

            _bookingEnd = bookingEnd;
        }


        public static BookingEnd FromDateTime(DateTime bookingEnd)
        {
            return new BookingEnd(bookingEnd);
        }
    }
}