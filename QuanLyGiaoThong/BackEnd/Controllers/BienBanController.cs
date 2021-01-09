using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class BienBanController : ApiController
    {
        // GET: api/BienBan
        public IEnumerable<BienBan> Get()
        {
            var db = new QuanLyGiaoThong();
            List<BienBan> bb = db.BienBans.ToList();
            return bb;
        }

        // GET: api/BienBan/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BienBan
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BienBan/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BienBan/5
        public void Delete(int id)
        {
        }
    }
}
