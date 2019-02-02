using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trip.Models;

namespace trip.Repository
{
    public class Repository
    {
        private List<MTrip> trips = new List<MTrip>
        {
            new MTrip {
                Id = 1,
                Name = "MVP Summit",
                StartDate = new DateTime(2018, 3, 5),
                EndDate = new DateTime(2018, 3, 8)
            },
            new MTrip {
                Id = 2,
                Name = "Travelling",
                StartDate = new DateTime(2018, 7, 25),
                EndDate = new DateTime(2018, 7, 28)
            },
            new MTrip {
                Id = 3,
                Name = "Business",
                StartDate = new DateTime(2018, 09, 4),
                EndDate = new DateTime(2018, 9, 10)
            }
        };
    }
}