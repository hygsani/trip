using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trip.Models
{
    public class MTrip
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}