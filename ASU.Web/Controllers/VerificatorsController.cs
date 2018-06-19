using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASU.DTO;
using ASU.DTO.Actors;
using ASU.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASU.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerificatorsController : ControllerBase
    {
        AppDbContext db;

        public VerificatorsController(AppDbContext dbContext)
        {
            db = dbContext;
        }

        // GET: api/Verificators/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var verificator = await db.Verificators.FirstOrDefaultAsync(v => v.Id == id);
            if (verificator == null)
                return NotFound();
            var view = new VerificatorView()
            {
                Id = id,
                Address = verificator.Address,
                Certificate = verificator.Certificate,
                Code = verificator.Code,
                Director = verificator.Director,
                Name = verificator.Name,
                Phone = verificator.Phone
            };
            return Ok(view);
        }

        // POST: api/Verificators
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] VerificatorView verificator)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ver = new Verificator()
            {
                Id = Guid.NewGuid().ToString(),
                Address = verificator.Address,
                Certificate = verificator.Certificate,
                Code = verificator.Code,
                Director = verificator.Director,
                Name = verificator.Name,
                Phone = verificator.Phone
            };
            await db.Verificators.AddAsync(ver);
            await db.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = ver.Id }, ver);
        }

        // PUT: api/Verificators/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody]VerificatorView verificator)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ver = await db.Verificators.FirstOrDefaultAsync(v => v.Id == id);
            ver.Address = verificator.Address;
            ver.Certificate = verificator.Certificate;
            ver.Code = verificator.Code;
            ver.Director = verificator.Director;
            ver.Name = verificator.Name;
            ver.Phone = verificator.Phone;

            db.Verificators.Update(ver);
            await db.SaveChangesAsync();
            return Ok(ver);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var ver = await db.Verificators.FirstOrDefaultAsync(v => v.Id == id);
            if (ver == null)
                return NotFound();

            db.Verificators.Remove(ver);
            await db.SaveChangesAsync();
            return NoContent();
        }
    }
}
