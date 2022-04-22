using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private DBregulator db = new DBregulator();

        [HttpPut("actions/1/endtime")]
        public IActionResult UpdateDate(DateTime date, int id)
        {
            bool res = db.CheckDateConstraints(date, id);
            db.CheckDateConstraints1();
            if (id < 0 || res == true)
            {
                return BadRequest("Parameters didn`t pass checking");
            }

            db.UpdateDate(date, id);
            return Ok("Updated");
        }
    }
}
