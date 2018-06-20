using System;
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
    public class VerificationDevicesController : ControllerBase
    {
        AppDbContext db;

        public VerificationDevicesController(AppDbContext dbContext)
        {
            db = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var device = await db.VerificationDevices.FirstOrDefaultAsync(v => v.Id == id);
            if (device == null)
                return NotFound();
            VerificationDeviceView view = new VerificationDeviceView()
            {
                Id = device.Id,
                Desc = device.AdditionalInfo,
                DKP = device.DKP,
                ExpirationDate = device.ExpirationDate,
                Name = device.Name
            };
            return Ok(view);
        }

        [HttpPost]
        public async Task<IActionResult> Post(VerificationDeviceView deviceView)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var device = new VerificationDevice()
            {
                Id = Guid.NewGuid().ToString(),
                AdditionalInfo = deviceView.Desc,
                DKP = deviceView.DKP,
                ExpirationDate = deviceView.ExpirationDate,
                Name = deviceView.Name
            };
            await db.VerificationDevices.AddAsync(device);
            await db.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = device.Id }, device);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, VerificationDeviceView deviceView)
        {
            var device = await db.VerificationDevices.FirstOrDefaultAsync(v => v.Id == id);
            if (device == null)
                return NotFound();


            device.AdditionalInfo = deviceView.Desc;
            device.DKP = deviceView.DKP;
            device.ExpirationDate = deviceView.ExpirationDate;
            device.Name = deviceView.Name;

            db.VerificationDevices.Update(device);
            await db.SaveChangesAsync();
            return Ok(device);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var device = await db.VerificationDevices.FirstOrDefaultAsync(v => v.Id == id);
            if (device == null)
                return NotFound();
            db.VerificationDevices.Remove(device);
            await db.SaveChangesAsync();
            return NoContent();
        }
    }
}