using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class NguoiDungController : ApiController
    {
        // GET: api/NguoiDung
        public IEnumerable<NguoiDung> Get()
        {
            QuanLyGiaoThong db = new QuanLyGiaoThong();
            List<NguoiDung> nd = db.NguoiDungs.ToList();
            return nd;
        }

        // GET: api/NguoiDung/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NguoiDung
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/NguoiDung/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/NguoiDung/5
        public void Delete(int id)
        {
        }
    }
}
