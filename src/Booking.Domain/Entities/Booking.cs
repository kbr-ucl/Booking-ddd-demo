using System.Diagnostics.CodeAnalysis;
using Booking.Domain.Values;
using Framework;

namespace Booking.Domain.Entities
{
    public class Booking : Entity<BookingId>
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

        public Booking(BookingId id, BookingTypeId bookingTypeId, StudentId studentId, TimeSlotId timeSlotId)
        {
            _bookingTypeId = bookingTypeId;
            _studentId = studentId;
            Id = id;
            _timeSlotId = timeSlotId;
        }

        // Identifier
        public BookingId Id { get; }

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

        protected override void When(object @event)
        {
            throw new System.NotImplementedException();
        }

        protected override void EnsureValidState()
        {
            throw new System.NotImplementedException();
        }
    }
}