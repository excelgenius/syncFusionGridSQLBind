using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFGrid.classes.DbModel;

namespace EFGrid.api.Repos
{
    public interface IOrganizationRepository
    {
        IEnumerable<Organization> GetAll();
        Organization GetByID(int nSAN);
        Organization AddRec(Organization cCls);
        Organization UpdateRec(Organization cCls);
        void DeleteRec(int nSAN);

    }
}
