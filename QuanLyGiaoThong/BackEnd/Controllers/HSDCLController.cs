using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class HSDCLController : ApiController
    {
        // GET: api/HSDCL
        public IEnumerable<HoSoDoi_CapLaiGPLX> Get()
        {
            var db = new QuanLyGiaoThong();
            List<HoSoDoi_CapLaiGPLX> dcl = db.HoSoDoi_CapLaiGPLX.ToList();
            return dcl;
        }

        // GET: api/HSDCL/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HSDCL
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/HSDCL/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HSDCL/5
        public void Delete(int id)
        {
        }
    }
}
