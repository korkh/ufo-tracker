using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using part1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using part1.DAl;

namespace part1.Controllers
{
    [Route("[controller]/[action]")]
    public class InfoController : ControllerBase
    {
        private readonly IInfoRepository _db;

        public InfoController(IInfoRepository db)
        {
            _db = db;
        }

        public async Task<bool> Registrer(Info info)
        {
            return await _db.Registrer(info);
        }

        public async Task<List<Info>> HentAlle()
        {
           return await _db.HentAlle();
        }

        public async Task<bool> Remove(int id)
        {
            return await _db.Remove(id);
        }

        public async Task<Info> HentEn(int id)
        {
            return await _db.HentEn(id);
        }

        public async Task<bool> Edit(Info editInfo)
        {
           return await _db.Edit(editInfo);
        }
    }
}
