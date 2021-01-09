using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class LopHocController : ApiController
    {
        // GET: api/LopHoc
        public IEnumerable<LopHoc> Get()
        {
            var db = new QuanLyGiaoThong();
            List<LopHoc> lh = db.LopHocs.ToList();
            return lh;
        }

        // GET: api/LopHoc/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LopHoc
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LopHoc/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LopHoc/5
        public void Delete(int id)
        {
        }
    }
}
