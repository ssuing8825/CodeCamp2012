using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeCamp2012.Models;
using CodeCamp2012.Repository;

namespace CodeCamp2012.Controllers
{
    public class HorsesController : ApiController
    {
        private HorseRepository repository = new HorseRepository();

        /// <summary>
        /// Get all horses
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Horse> Get()
        {
            return repository.GetAll();

        }

        /// <summary>
        /// Get a single horse
        /// </summary>
        /// <param name="id">Ide of the horse</param>
        /// <returns>A horse</returns>
        public Horse Get(int id)
        {

            return repository.Get(id);
        }

        // POST api/horses
        public void Post([FromBody]Horse value)
        {
            repository.Post(value);
        }

        // PUT api/horses/5
        public void Put(int id, [FromBody]Horse value)
        {
            repository.Update(value);
        }

        // DELETE api/horses/5
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
