using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survivor.Model.Context;
using Survivor.Model.Entities;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CompetitorController(SurvivorDbContext context)
        {
            _context = context;
        }

        // GET: /api/competitors
        [HttpGet]
        public IActionResult GetAllCompetitors()
        {
            var competitors = _context.Competitors.ToList();
            return Ok(competitors);
        }

        // GET: /api/competitors/{id}
        [HttpGet("{id}")]
        public IActionResult GetCompetitorById(int id)
        {
            var competitor = _context.Competitors.Find(id);
            if (competitor == null) return NotFound();
            return Ok(competitor);
        }

        // GET: /api/competitors/categories/{categoryId}
        [HttpGet("categories/{categoryId}")]
        public IActionResult GetCompetitorsByCategory(int categoryId)
        {
            var competitors = _context.Competitors.Where(c => c.CategoryId == categoryId).ToList();
            return Ok(competitors);
        }

        // POST: /api/competitors
        [HttpPost]
        public IActionResult CreateCompetitor([FromBody] Competitor competitor)
        {
            _context.Competitors.Add(competitor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCompetitorById), new { id = competitor.Id }, competitor);
        }

        // PUT: /api/competitors/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCompetitor(int id, [FromBody] Competitor competitor)
        {
            var value = _context.Competitors.Find(id);
            if (value == null) return NotFound();

            value.Name = competitor.Name;
            value.CategoryId = competitor.CategoryId;
            value.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: /api/competitors/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCompetitor(int id)
        {
            var competitor = _context.Competitors.Find(id);
            if (competitor == null) return NotFound();

            _context.Competitors.Remove(competitor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
