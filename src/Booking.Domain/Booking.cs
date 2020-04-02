using System;
using System.Collections.Generic;
using System.Text;
using Framework;

namespace Booking.Domain
{
    public class Booking
    {
        public Booking(Guid id, BookingTypeId bookingTypeId, StudentId studentId, TimeSlotId timeSlotId)
        {
            _bookingTypeId = bookingTypeId;
            _studentId = studentId;
            Id = id;
            _timeSlotId = timeSlotId;
        }
        // Identifier
        public Guid Id { get; set; }
        // Value
        private BookingTypeId _bookingTypeId;
        // Value
        private StudentId _studentId;
        
        
        // Value
        private TimeSlotId _timeSlotId;

        // Value
        private BookingStart _bookingStart;
        // Value
        private BookingEnd _bookingEnd;

        public void UpdateTimeSlot(TimeSlotId timeSlotId)
        {
            _timeSlotId = timeSlotId;
        }

        public void UpdateBookingStart(BookingStart bookingStart)
        {
            _bookingStart= bookingStart;
        }
        public void UpdateBookingEnd(BookingEnd bookingEnd)
        {
            _bookingEnd= bookingEnd;
        }


    }

    public class BookingEnd : Value<BookingEnd>
    {
        private DateTime _bookingEnd;


        private BookingEnd(DateTime bookingEnd)
        {
            if (bookingEnd == default)
                throw new ArgumentException(
                    "Booking start skal være sat",
                    nameof(bookingEnd));
        }

        //internal BookingEnd(DateTime bookingEnd)
        //{
        //}

        public new static BookingEnd FromDateTime(DateTime bookingEnd)
        {
            return new BookingEnd(bookingEnd);
        }
    }

    public class BookingStart
    {
        private DateTime _bookingStart;
    }

    public class BookingTypeId
    {
        private Guid _bookingTypeId;
    }

    public class TimeSlotId
    {
        private Guid _timeSlotId;
    }

    public class StudentId
    {
        private Guid _studentId;
    }
}
