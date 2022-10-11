using part1.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace part1.DAl
{
    public interface IInfoRepository
    {
        Task<bool> Registrer(Info info);
        Task<List<Info>> HentAlle();
        Task<bool> Remove(int id);
        Task<Info> HentEn(int id);
        Task<bool> Edit(Info editInfo);
    }
}
