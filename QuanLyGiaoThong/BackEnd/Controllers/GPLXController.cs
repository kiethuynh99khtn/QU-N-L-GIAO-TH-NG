using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class GPLXController : ApiController
    {
        // GET: api/GPLX
        public IEnumerable<GiayPhepLaiXe> Get()
        {
            var db = new QuanLyGiaoThong();
            List<GiayPhepLaiXe> gplx = db.GiayPhepLaiXes.ToList();
            return gplx;
        }

        // GET: api/GPLX/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GPLX
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GPLX/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GPLX/5
        public void Delete(int id)
        {
        }
    }
}
