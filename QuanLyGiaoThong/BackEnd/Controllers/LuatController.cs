using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class LuatController : ApiController
    {
        // GET: api/Luat
        public IEnumerable<LuatGiaoThong> Get()
        {
            var db = new QuanLyGiaoThong();
            List<LuatGiaoThong> l = db.LuatGiaoThongs.ToList();
            return l;
        }

        // GET: api/Luat/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Luat
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Luat/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Luat/5
        public void Delete(int id)
        {
        }
    }
}
