using System;
using Framework;

namespace Booking.Domain
{
    public class Booking
    {
        // Value
        private BookingEnd _bookingEnd;

        // Value
        private BookingStart _bookingStart;

        // Value
        private BookingTypeId _bookingTypeId;

        // Value
        private StudentId _studentId;


        // Value
        private TimeSlotId _timeSlotId;

        public Booking(Guid id, BookingTypeId bookingTypeId, StudentId studentId, TimeSlotId timeSlotId)
        {
            _bookingTypeId = bookingTypeId;
            _studentId = studentId;
            Id = id;
            _timeSlotId = timeSlotId;
        }

        // Identifier
        public Guid Id { get; set; }

        public void UpdateTimeSlot(TimeSlotId timeSlotId)
        {
            _timeSlotId = timeSlotId;
        }

        public void UpdateBookingStart(BookingStart bookingStart)
        {
            _bookingStart = bookingStart;
        }

        public void UpdateBookingEnd(BookingEnd bookingEnd)
        {
            _bookingEnd = bookingEnd;
        }
    }

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

        //internal BookingEnd(DateTime bookingEnd)
        //{
        //}

        public static BookingEnd FromDateTime(DateTime bookingEnd)
        {
            return new BookingEnd(bookingEnd);
        }
    }

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

    public class BookingTypeId : Value<BookingTypeId>
    {
        private Guid _bookingTypeId;

        private BookingTypeId(Guid bookingTypeId)
        {
            if (bookingTypeId == default)
                throw new ArgumentException(
                    "Bookingtype skal være sat",
                    nameof(bookingTypeId));

            _bookingTypeId = bookingTypeId;
        }


        public static BookingTypeId FromGuid(Guid bookingTypeId)
        {
            return new BookingTypeId(bookingTypeId);
        }
    }

    public class TimeSlotId
    {
        private Guid _timeSlotId;

        private TimeSlotId(Guid timeSlotId)
        {
            if (timeSlotId == default)
                throw new ArgumentException(
                    "Time slot skal være sat",
                    nameof(timeSlotId));

            _timeSlotId = timeSlotId;
        }


        public static TimeSlotId FromGuid(Guid timeSlotId)
        {
            return new TimeSlotId(timeSlotId);
        }
    }

    public class StudentId : Value<BookingTypeId>
    {
        private Guid _studentId;

        private StudentId(Guid studentId)
        {
            if (studentId == default)
                throw new ArgumentException(
                    "StudentId skal være sat",
                    nameof(studentId));

            _studentId = studentId;
        }


        public static StudentId FromGuid(Guid studentId)
        {
            return new StudentId(studentId);
        }
    }
}