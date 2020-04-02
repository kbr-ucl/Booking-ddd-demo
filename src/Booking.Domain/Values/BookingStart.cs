using System;
using Framework;

namespace Booking.Domain.Values
{
    public class BookingStart : Value<BookingStart>
    {
        private DateTime _bookingStart;

        private BookingStart(DateTime bookingStart)
        {
            if (bookingStart == default)
                throw new ArgumentException(
                    "Booking start dato/tid skal være sat",
                    nameof(bookingStart));

            _bookingStart = bookingStart;
        }


        public static BookingStart FromDateTime(DateTime bookingStart)
        {
            return new BookingStart(bookingStart);
        }
    }
}