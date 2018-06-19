﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASU.DTO;
using ASU.DTO.Entities;
using ASU.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASU.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestEquipmentsController : ControllerBase
    {
        AppDbContext db;

        public TestEquipmentsController(AppDbContext dbContext)
        {
            db = dbContext;
        }
        // GET: api/TestEquipments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var test = await db.TestEquipments.FirstOrDefaultAsync(t => t.Id == id);
            if (test == null)
                return NotFound(id);

            var view = new TestEquipmentView()
            {
                Id = id,
                Country = test.TECoutry,
                Model = test.TEModel,
                ManufactureDate = test.TEManufatureDate,
                Name = test.Name,
                Producer = test.TEProducer,
                WorkNumber = test.TEWorkNumber
            };
            return Ok(view);
        }

        // POST: api/TestEquipments
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TestEquipmentView model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var test = new TestEquipment()
            {
                Id = Guid.NewGuid().ToString(),
                TECoutry = model.Country,
                Name = model.Name,
                TEManufatureDate = model.ManufactureDate,
                TEModel = model.Model,
                TEProducer = model.Producer,
                TEWorkNumber = model.WorkNumber
            };
            await db.TestEquipments.AddAsync(test);
            await db.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = test.Id }, test);
        }

        // PUT: api/TestEquipments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] TestEquipmentView model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var test = await db.TestEquipments.FirstOrDefaultAsync(t => t.Id == id);

            test.TECoutry = model.Country;
            test.TEManufatureDate = model.ManufactureDate;
            test.TEModel = model.Model;
            test.TEProducer = model.Producer;
            test.TEWorkNumber = model.WorkNumber;
            test.Name = model.Name;

            db.TestEquipments.Update(test);
            await db.SaveChangesAsync();
            return Ok(test);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var test = await db.TestEquipments.FirstOrDefaultAsync(t => t.Id == id);
            if (test == null)
                return NotFound(id);

            db.TestEquipments.Remove(test);
            await db.SaveChangesAsync();
            return NoContent();
        }
    }
}
