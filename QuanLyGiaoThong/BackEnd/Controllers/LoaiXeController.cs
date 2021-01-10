using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class LoaiXeController : ApiController
    {
        // GET: api/LoaiXe
        public IEnumerable<LoaiXe> Get()
        {
            var db = new QuanLyGiaoThong();
            List<LoaiXe> lx = db.LoaiXes.ToList();
            return lx;
        }

        // GET: api/LoaiXe/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LoaiXe
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LoaiXe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LoaiXe/5
        public void Delete(int id)
        {
        }
    }
}
