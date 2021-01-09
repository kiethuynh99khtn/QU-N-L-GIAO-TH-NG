using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class NguoiQuanLyController : ApiController
    {
        // GET: api/NguoiQuanLy
        public IEnumerable<NguoiQuanLy> Get()
        {
            var db = new QuanLyGiaoThong();
            List<NguoiQuanLy> nql = db.NguoiQuanLies.ToList();
            return nql;
        }

        // GET: api/NguoiQuanLy/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NguoiQuanLy
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/NguoiQuanLy/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/NguoiQuanLy/5
        public void Delete(int id)
        {
        }
    }
}
