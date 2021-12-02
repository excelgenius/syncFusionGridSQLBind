using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

using EFGrid.classes.DbModel;
using EFGrid.api.Repos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF1.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {

        private readonly IOrganizationRepository _orgRepo;

        public OrganizationController(IOrganizationRepository orgRepo)
        {
            _orgRepo = orgRepo;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public object GetAll()
        {
            IQueryable<Organization> data = _orgRepo.GetAll().AsQueryable();
            var count = data.Count();
            var queryString = Request.Query;
            if (queryString.Keys.Contains("$inlinecount"))
            {
                StringValues Skip;
                StringValues Take;
                int skip = (queryString.TryGetValue("$skip", out Skip)) ? Convert.ToInt32(Skip[0]) : 0;
                int top = (queryString.TryGetValue("$top", out Take)) ? Convert.ToInt32(Take[0]) : data.Count();
                return new { Items = data.Skip(skip).Take(top), Count = count };
            }
            else
            {
                return data;
            }
        }


        // GET api/<controller>/5
        [HttpGet("{nSAN}")]
        public IActionResult GetByID(int nSAN)
        {
            return Ok(_orgRepo.GetByID(nSAN));
        }



        // POST api/<ValuesController>
        [HttpPost]
        public object AddRec([FromBody] Organization cCls)
        {
            if (cCls == null)
                return BadRequest();

            if (cCls.OrgName == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var c1 = _orgRepo.AddRec(cCls);
            return cCls;

            //return Created("Organization", c1);
        }



        [HttpPut]
        public object UpdateRec([FromBody] Organization cCls)
        {
            if (cCls == null)
                return BadRequest();

            if (cCls.OrgName == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Console.WriteLine("userController.UpdateRec");
            var vToUpdate = _orgRepo.GetByID(cCls.Orgsan);

            if (vToUpdate == null)
                return NotFound();

            _orgRepo.UpdateRec(cCls);

            return cCls; //success
        }


        [HttpDelete("{nSAN}")]
        public IActionResult DeleteRec(int nSAN)
        {
            if (nSAN == 0)
                return BadRequest();

            var fthToDel = _orgRepo.GetByID(nSAN);
            if (fthToDel == null)
                return NotFound();

            _orgRepo.DeleteRec(nSAN);

            return NoContent();//success
        }
    }
}
