using System;
using Framework;

namespace Booking.Domain.Values
{
    public class BookingTypeId : Value<BookingTypeId>
    {
        public Guid Value { get; }

        private BookingTypeId(Guid bookingTypeId)
        {
            if (bookingTypeId == default)
                throw new ArgumentException(
                    "Bookingtype skal være sat",
                    nameof(bookingTypeId));

            Value = bookingTypeId;
        }


        public static BookingTypeId FromGuid(Guid bookingTypeId)
        {
            return new BookingTypeId(bookingTypeId);
        }

        public static implicit operator Guid(BookingTypeId id)
        {
            return id.Value;
        }
    }
}