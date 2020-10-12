using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIHandson5_6.Models;

namespace WebAPIHandson5_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmpDBContext context;
        public EmployeeController(EmpDBContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var query = from obj in context.Emp
                        select obj;
            var data = await query.ToListAsync();
            return Ok(data);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromBody] Employee emp)
        {
            //if(ModelState.IsValid==false)
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            context.Emp.Add(emp);
            int rows = await context.SaveChangesAsync();

            if (rows > 0)
                return StatusCode(201);

            return BadRequest("Failed to save employee");
        }

    }
}
