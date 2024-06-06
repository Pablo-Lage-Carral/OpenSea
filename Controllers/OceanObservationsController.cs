using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OceanObservationAPI.Data;
using OceanObservationAPI.Models;


namespace OceanObservationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OceanObservationsController : ControllerBase
    {
        private readonly OceanDataContext _context;

        public OceanObservationsController(OceanDataContext context)
        {
            _context = context;
        }

        // GET: api/OceanObservations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OceanObservation>>> GetOceanObservations()
        {
            return await _context.OceanObservations.ToListAsync();
        }

        // GET: api/OceanObservations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OceanObservation>> GetOceanObservation(int id)
        {
            var observation = await _context.OceanObservations.FindAsync(id);

            if (observation == null)
            {
                return NotFound();
            }

            return observation;
        }

        // POST: api/OceanObservations
        [HttpPost]
        public async Task<ActionResult<OceanObservation>> PostOceanObservation([FromBody]OceanObservation observation)
        {
            _context.OceanObservations.Add(observation);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOceanObservation), new { id = observation.Id }, observation);
        }

        // PUT: api/OceanObservations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOceanObservation(int id, [FromBody]OceanObservation observation)
        {
            if (id != observation.Id)
            {
                return BadRequest();
            }

            _context.Entry(observation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OceanObservationExists(id))
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

        // DELETE: api/OceanObservations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOceanObservation(int id)
        {
            var observation = await _context.OceanObservations.FindAsync(id);
            if (observation == null)
            {
                return NotFound();
            }

            _context.OceanObservations.Remove(observation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OceanObservationExists(int id)
        {
            return _context.OceanObservations.Any(e => e.Id == id);
        }
    }
}
