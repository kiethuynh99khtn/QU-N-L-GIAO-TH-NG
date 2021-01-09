using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class XeController : ApiController
    {
        // GET: api/Xe
        public IEnumerable<Xe> Get()
        {
            var db = new QuanLyGiaoThong();
            List<Xe> x = db.Xes.ToList();
            return x;
        }

        // GET: api/Xe/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Xe
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Xe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Xe/5
        public void Delete(int id)
        {
        }
    }
}
