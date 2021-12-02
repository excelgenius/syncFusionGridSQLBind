using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFGrid.classes.DbModel;

namespace EFGrid.api.Repos
{
    public class RegionRepository : IRegionRepository
    {

        private readonly AppDbContext _AppDbContext;

        public RegionRepository(AppDbContext AppDbContext)
        {
            _AppDbContext = AppDbContext;
        }


        public IEnumerable<Region> GetAll()
        {
            return _AppDbContext.Regions.OrderBy(s => s.RegionDescription);
        }


        public Region GetByID(int nSAN)
        {
            return _AppDbContext.Regions.FirstOrDefault(c => c.RegionId == nSAN);
        }


        public Region AddRec(Region cCls)
        {
            var addedEntity = _AppDbContext.Regions.Add(cCls);
            _AppDbContext.SaveChanges();
            return addedEntity.Entity;
        }



        public Region UpdateRec(Region cCls)
        {
            //https://developer.okta.com/blog/2018/04/26/build-crud-app-aspnetcore-angular
            _AppDbContext.Entry(cCls).State = EntityState.Modified;
            _AppDbContext.SaveChanges();
            return cCls;
        }



        public void DeleteRec(int nSAN)
        {
            var vFound = _AppDbContext.Regions.FirstOrDefault(e => e.RegionId == nSAN);
            if (vFound == null) return;

            _AppDbContext.Regions.Remove(vFound);
            _AppDbContext.SaveChanges();
        }




        
    }
}
