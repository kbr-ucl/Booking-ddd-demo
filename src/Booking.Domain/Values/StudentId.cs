using System;
using Framework;

namespace Booking.Domain.Values
{
    public class StudentId : Value<BookingTypeId>
    {
        public Guid Value { get; }

        private StudentId(Guid studentId)
        {
            if (studentId == default)
                throw new ArgumentException(
                    "StudentId skal være sat",
                    nameof(studentId));

            Value = studentId;
        }


        public static StudentId FromGuid(Guid studentId)
        {
            return new StudentId(studentId);
        }

        public static implicit operator Guid(StudentId id)
        {
            return id.Value;
        }
    }
}