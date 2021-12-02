using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EFGrid.api.Repos;
using EFGrid.classes.DbModel;

namespace EFGrid.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }


        // GET: api/<controller>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userRepo.GetAll());
        }


        // GET api/<controller>/5
        [HttpGet("{sGUID}")]
        public IActionResult GetByGUID(string sGUID)
        {
            return Ok(_userRepo.GetByGUID(sGUID));
        }


        [HttpPost]
        public IActionResult AddRec([FromBody] AspNetUser cCls)
        {
            if (cCls == null)
                return BadRequest();

            if (cCls.Email == string.Empty)
            {
                ModelState.AddModelError("Email", "The email shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var c1 = _userRepo.AddRec(cCls);

            return Created("AspNetUser", c1);
        }


        [HttpPut]
        public IActionResult UpdateRec([FromBody] AspNetUser cCls)
        {
            if (cCls == null)
                return BadRequest();

            if (cCls.Email == string.Empty)
            {
                ModelState.AddModelError("Email", "The email shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Console.WriteLine("userController.UpdateRec");
            var vToUpdate = _userRepo.GetByGUID(cCls.Id);

            if (vToUpdate == null)
                return NotFound();

            _userRepo.UpdateRec(cCls);

            return NoContent(); //success
        }


        [HttpDelete("{sGUID}")]
        public IActionResult DeleteRec(string sGUID)
        {
            if (sGUID == "")
                return BadRequest();

            var fthToDel = _userRepo.GetByGUID(sGUID);
            if (fthToDel == null)
                return NotFound();

            _userRepo.DeleteRec(sGUID);

            return NoContent();//success
        }

    }
}
