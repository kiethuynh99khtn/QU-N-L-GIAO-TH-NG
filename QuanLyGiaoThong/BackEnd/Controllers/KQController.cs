using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class KQController : ApiController
    {
        // GET: api/KQ
        public IEnumerable<KetQuaSatHach> Get()
        {
            var db = new QuanLyGiaoThong();
            List<KetQuaSatHach> kq = db.KetQuaSatHaches.ToList();
            return kq;
        }

        // GET: api/KQ/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/KQ
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/KQ/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/KQ/5
        public void Delete(int id)
        {
        }
    }
}
