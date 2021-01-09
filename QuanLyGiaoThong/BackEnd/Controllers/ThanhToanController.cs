using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class ThanhToanController : ApiController
    {
        // GET: api/ThanhToan
        public IEnumerable<ThanhToan> Get()
        {
            var db = new QuanLyGiaoThong();
            List<ThanhToan> tt = db.ThanhToans.ToList();
            return tt;
        }

        // GET: api/ThanhToan/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ThanhToan
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ThanhToan/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ThanhToan/5
        public void Delete(int id)
        {
        }
    }
}
