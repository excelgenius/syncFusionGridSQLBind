using EFGrid.classes.DbModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFGrid.app.Data
{
    public interface IRegionDataService
    {
        Task<IEnumerable<Region>> Regions();

        Task<Region> GetByID(int nID);
        Task<Region> AddNew(Region cCLS);
        Task UpdateRec(Region cCLS);
        Task DeleteRec(int nID);
    }
}
