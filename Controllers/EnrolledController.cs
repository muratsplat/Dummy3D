using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dummy3D.Models.Request;
using Dummy3D.Models.Response;

namespace Dummy3D.Controllers
{   
    [Produces("application/json")]
    [Route("api/3d/enrolment")]
    public class EnrolledController : Controller
    {
        [ProducesResponseType(200, Type = typeof(ResEnrolled))]
        [ProducesResponseType(400, Type = typeof(Error) )]
        [HttpPost("do")] 
        public IActionResult Do([FromBody] ReqEnrolled req ) 
        {            
            
            if (ModelState.IsValid) {


            }
            Error err = new Error();
            err.Errors = ModelState;
            err.Status = Status.Invalid;
            return BadRequest(err);
        }


    }
}
