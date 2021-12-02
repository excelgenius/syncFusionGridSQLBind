using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using EFGrid.classes.DbModel;

namespace EFGrid.api.Repos
{
    public class UserRepository : IUserRepository
    {
        private readonly _AWBContext _appDbContext;

        public UserRepository(_AWBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<AspNetUser> GetAll()
        {
            return _appDbContext.AspNetUsers.OrderBy(s => s.UserName);
        }



        public AspNetUser GetByGUID(string sGUID)
        {
            return _appDbContext.AspNetUsers.FirstOrDefault(c => c.Id == sGUID);
        }



        public AspNetUser AddRec(AspNetUser clsRepo)
        {
            var addedEntity = _appDbContext.AspNetUsers.Add(clsRepo);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }


        public AspNetUser UpdateRec(AspNetUser clsRepo)
        {
            Console.WriteLine("UserRepor.cs:UpdateRec");
            var vFound = _appDbContext.AspNetUsers.FirstOrDefault(e => e.Id == clsRepo.Id);

            if (vFound != null)
            {
                vFound.UserName = clsRepo.UserName;
                vFound.Email = clsRepo.Email;

                //test if this code can work rather just updating each field one at a time
                //_appDbContext.FieldGrouping.Update(vFound);
                _appDbContext.SaveChanges();

                return vFound;
            }

            return null;
        }


        public void DeleteRec(string sGUID)
        {
            var vFound = _appDbContext.AspNetUsers.FirstOrDefault(e => e.Id == sGUID);
            if (vFound == null) return;

            _appDbContext.AspNetUsers.Remove(vFound);
            _appDbContext.SaveChanges();

        }

    }
}
