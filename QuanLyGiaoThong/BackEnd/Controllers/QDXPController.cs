using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class QDXPController : ApiController
    {
        // GET: api/QDXP
        public IEnumerable<QuyetDinhXuPhat> Get()
        {
            var db = new QuanLyGiaoThong();
            List<QuyetDinhXuPhat> qdxp = db.QuyetDinhXuPhats.ToList();
            return qdxp;
        }

        // GET: api/QDXP/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/QDXP
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/QDXP/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/QDXP/5
        public void Delete(int id)
        {
        }
    }
}
