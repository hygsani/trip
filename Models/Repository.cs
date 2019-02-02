using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trip.Models;

namespace trip.Models
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

        public List<MTrip> Get()
        {
            return trips;
        }
        public MTrip GetById(int id)
        {
            return trips.First(t => t.Id == id);
        }
        public void Create(MTrip trip)
        {
            trips.Add(trip);
        }

        public void Update(MTrip trip)
        {
            trips.Remove(trips.First(t => t.Id == trip.Id));
            Create(trip);
        }

        public void Delete(int id)
        {
            trips.Remove(trips.First(t => t.Id == id));
        }
    }
}