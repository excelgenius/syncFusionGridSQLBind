using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFGrid.classes.DbModel;

namespace EFGrid.api.Repos
{
    public class OrganizationRepository : IOrganizationRepository
    {

        private readonly _AWBContext _appDbContext;

        public OrganizationRepository(_AWBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<Organization> GetAll()
        {
            return _appDbContext.Organizations.OrderBy(s => s.OrgName);
        }


        public Organization GetByID(int nSAN)
        {
            return _appDbContext.Organizations.FirstOrDefault(c => c.Orgsan == nSAN);
        }


        public Organization AddRec(Organization cCls)
        {
            var addedEntity = _appDbContext.Organizations.Add(cCls);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }



        public Organization UpdateRec(Organization cCls)
        {
            //https://developer.okta.com/blog/2018/04/26/build-crud-app-aspnetcore-angular
            _appDbContext.Entry(cCls).State = EntityState.Modified;
            _appDbContext.SaveChanges();
            return cCls;
        }



        public void DeleteRec(int nSAN)
        {
            var vFound = _appDbContext.Organizations.FirstOrDefault(e => e.Orgsan == nSAN);
            if (vFound == null) return;

            _appDbContext.Organizations.Remove(vFound);
            _appDbContext.SaveChanges();
        }




        
    }
}
