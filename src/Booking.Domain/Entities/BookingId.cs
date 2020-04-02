using System;

namespace Booking.Domain.Entities
{
    public class BookingId : IEquatable<BookingId>
    {
        public BookingId(Guid value)
        {
            if (value == default)
                throw new ArgumentNullException(nameof(value), "Booking Ad id cannot be empty");

            Value = value;
        }

        private Guid Value { get; }

        public bool Equals(BookingId other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value.Equals(other.Value);
        }

        public static implicit operator Guid(BookingId self)
        {
            return self.Value;
        }

        public static implicit operator BookingId(string value)
        {
            return new BookingId(Guid.Parse(value));
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((BookingId) obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}