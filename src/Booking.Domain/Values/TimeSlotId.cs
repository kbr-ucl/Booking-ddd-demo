using System;

namespace Booking.Domain.Values
{
    public class TimeSlotId
    {
        public Guid Value { get; }

        private TimeSlotId(Guid timeSlotId)
        {
            if (timeSlotId == default)
                throw new ArgumentException(
                    "Time slot skal være sat",
                    nameof(timeSlotId));

            Value = timeSlotId;
        }


        public static TimeSlotId FromGuid(Guid timeSlotId)
        {
            return new TimeSlotId(timeSlotId);
        }

        public static implicit operator Guid(TimeSlotId id)
        {
            return id.Value;
        }
    }
}