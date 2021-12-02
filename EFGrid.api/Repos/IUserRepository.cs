using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFGrid.classes.DbModel;

namespace EFGrid.api.Repos
{
    public interface IUserRepository
    {
        IEnumerable<AspNetUser> GetAll();
        AspNetUser GetByGUID(string sGUID);
        AspNetUser AddRec(AspNetUser cCls);
        AspNetUser UpdateRec(AspNetUser cCls);
        void DeleteRec(string sGUID);

    }
}
