using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Task4.Models;

namespace Task4.Controllers
{
    //[RequireHttps]
    public class TalentsController : ApiController
    {
        static readonly TalentRepository repository = new TalentRepository();


        [HttpGet]
        // Azure
        //[EnableCors(origins: "https://p1845259-task4.azurewebsites.net/", headers: "*", methods: "*")]
        // School assignment DEMO
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/talents")]
        public IEnumerable<Talent> GetAllTalents()
        {
            return repository.GetAll();
        }

        [HttpGet]
        [Route("api/talents/{id:int}")]
        public Talent GetTalent(int id)
        {
            Talent item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

    }
}
