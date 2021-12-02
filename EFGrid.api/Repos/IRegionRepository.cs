using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFGrid.classes.DbModel;

namespace EFGrid.api.Repos
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();
        Region GetByID(int nSAN);
        Region AddRec(Region cCls);
        Region UpdateRec(Region cCls);
        void DeleteRec(int nSAN);

    }
}
