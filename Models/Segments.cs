using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trip.Models
{
    public class Segments
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTimeOffset StartDateTime { get; set; }

        public DateTimeOffset EndDateTime { get; set; }

        public string Description { get; set; }

        public int TripId { get; set; }
    }
}