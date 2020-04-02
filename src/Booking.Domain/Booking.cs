using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Domain
{
    public class Booking
    {
        // Identifier
        public Guid Id { get; set; }
        
        // Value
        public Guid StudentId { get; set; }
        // Value
        public Guid TimeSlotId { get; set; }
        // Value
        public Guid BookingTypeId { get; set; }
        // Value
        public DateTime BookingStart { get; set; }
        // Value
        public DateTime BookingEnd { get; set; }

    }
}
