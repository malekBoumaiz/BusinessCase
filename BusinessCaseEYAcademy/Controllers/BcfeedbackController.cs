using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessCaseEYAcademy.Models;

namespace BusinessCaseEYAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BcfeedbackController : ControllerBase
    {
        private readonly BusinessCaseContext _context;

        public BcfeedbackController(BusinessCaseContext context)
        {
            _context = context;
        }

        // GET: api/Bcfeedback
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bcfeedback>>> GetBcfeedbacks()
        {
            return await _context.Bcfeedbacks.ToListAsync();
        }

        // GET: api/Bcfeedback/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bcfeedback>> GetBcfeedback(int id)
        {
            var bcfeedback = await _context.Bcfeedbacks.FindAsync(id);

            if (bcfeedback == null)
            {
                return NotFound();
            }

            return bcfeedback;
        }

        // PUT: api/Bcfeedback/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBcfeedback(int id, Bcfeedback bcfeedback)
        {
            if (id != bcfeedback.FeedbackId)
            {
                return BadRequest();
            }

            _context.Entry(bcfeedback).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BcfeedbackExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Bcfeedback
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bcfeedback>> PostBcfeedback(Bcfeedback bcfeedback)
        {
            _context.Bcfeedbacks.Add(bcfeedback);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBcfeedback", new { id = bcfeedback.FeedbackId }, bcfeedback);
        }

        // DELETE: api/Bcfeedback/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBcfeedback(int id)
        {
            var bcfeedback = await _context.Bcfeedbacks.FindAsync(id);
            if (bcfeedback == null)
            {
                return NotFound();
            }

            _context.Bcfeedbacks.Remove(bcfeedback);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BcfeedbackExists(int id)
        {
            return _context.Bcfeedbacks.Any(e => e.FeedbackId == id);
        }
    }
}
