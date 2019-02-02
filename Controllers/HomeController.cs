using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trip.Models;

namespace trip.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private Repository _repository;

        public HomeController(Repository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<MTrip> Get()
        {
            return _repository.Get();
        }

        [HttpGet("{id}")]
        public MTrip GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]MTrip value)
        {
            _repository.Create(value);
        }

        [HttpPut]
        public void Put(int id, [FromBody]MTrip value)
        {
            _repository.Update(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
