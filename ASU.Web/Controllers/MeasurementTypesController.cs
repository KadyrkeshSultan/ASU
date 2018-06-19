using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASU.DTO;
using ASU.DTO.Entities;
using Microsoft.AspNetCore.Authorization;
using ASU.Web.Models;

namespace ASU.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementTypesController : ControllerBase
    {
        private readonly AppDbContext db;

        public MeasurementTypesController(AppDbContext context)
        {
            db = context;
        }

        // GET: api/MeasurementTypes
        [HttpGet]
        public IEnumerable<MeasurementType> GetMeasurementTypes()
        {
            return db.MeasurementTypes;
        }

        // GET: api/MeasurementTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMeasurementType([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var measurementType = await db.MeasurementTypes.FindAsync(id);

            if (measurementType == null)
            {
                return NotFound();
            }

            return Ok(measurementType);
        }

        // PUT: api/MeasurementTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeasurementType([FromRoute] string id, [FromBody] MeasurementTypeView measurementType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var type = await db.MeasurementTypes.FirstOrDefaultAsync(m => m.Id == id);

            if (type == null)
                return NotFound(id);
            type.Name = measurementType.Name;
            db.MeasurementTypes.Update(type);
            await db.SaveChangesAsync();

            return Ok(type);
        }

        // POST: api/MeasurementTypes
        [HttpPost]
        public async Task<IActionResult> PostMeasurementType([FromBody] MeasurementTypeView measurementType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            MeasurementType type = new MeasurementType() { Id = Guid.NewGuid().ToString(), Name = measurementType.Name };
            db.MeasurementTypes.Add(type);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetMeasurementType", new { id = type.Id }, type);
        }

        // DELETE: api/MeasurementTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeasurementType([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var measurementType = await db.MeasurementTypes.FindAsync(id);
            if (measurementType == null)
            {
                return NotFound();
            }

            db.MeasurementTypes.Remove(measurementType);
            await db.SaveChangesAsync();

            return NoContent();
        }

        private bool MeasurementTypeExists(string id)
        {
            return db.MeasurementTypes.Any(e => e.Id == id);
        }
    }
}