using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class DK_GPLXController : ApiController
    {
        // GET: api/DK_GPLX
        public IEnumerable<DangKyGPLX> Get()
        {
            var db = new QuanLyGiaoThong();
            List<DangKyGPLX> dk = db.DangKyGPLXes.ToList();
            return dk;
        }

        // GET: api/DK_GPLX/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DK_GPLX
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DK_GPLX/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DK_GPLX/5
        public void Delete(int id)
        {
        }
    }
}
