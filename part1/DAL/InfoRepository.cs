using Microsoft.EntityFrameworkCore;
using part1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace part1.DAL
{
    public class InfoRepository : IInfoRepository
    {
        private readonly InfoContext _db;

        public InfoRepository(InfoContext db)
        {
            _db = db;
        }

        public async Task<bool> Edit(Info editInfo)
        {
            try
            {
                var eInfo = await _db.Infoer.FindAsync(editInfo.Id);

                eInfo.Date = editInfo.Date;
                eInfo.Country = editInfo.Country;
                eInfo.Shape = editInfo.Shape;
                eInfo.Country = editInfo.Country;
                eInfo.Duration = editInfo.Duration;
                eInfo.Describtion = editInfo.Describtion;

                await _db.SaveChangesAsync();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async Task<List<Info>> HentAlle()
        {
            try
            {
                List<Info> allInfo = await _db.Infoer.Select(i => new Info
                {
                    Id = i.Id,
                    Date = i.Date,
                    Country = i.Country,
                    Shape = i.Shape,
                    Duration = i.Duration,
                    Describtion = i.Describtion,
                }).ToListAsync();
                return allInfo;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Info> HentEn(int id)
        {
            Info info = await _db.Infoer.FindAsync(id);
            var foundInfo = new Info()
            {
                Id = info.Id,
                Date = info.Date,
                Country = info.Country,
                Shape = info.Shape,
                Duration = info.Duration,
                Describtion = info.Describtion,
            };
            return foundInfo;
        }

        public async Task<bool> Registrer(Info info)
        {
            try
            {
                var newInfo = new Info
                {
                    Date = info.Date,
                    Country = info.Country,
                    Shape = info.Shape,
                    Duration = info.Duration,
                    Describtion = info.Describtion,
                };
                _db.Infoer.Add(newInfo);
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                Info info = await _db.Infoer.FindAsync(id);
                _db.Infoer.Remove(info);
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
