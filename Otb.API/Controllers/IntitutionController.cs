using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Otb.Domain;
using Otb.Persistence;

namespace Otb.API.Controllers
{
    public class IntitutionController : BaseApiController
    {
        public readonly DataContext _context; 
        public IntitutionController(DataContext context)
        {
            _context = context;            
        }

        [HttpGet]
        public async Task<ActionResult<List<Institution>>> GetIntitutions()
        {
            return await _context.Institutions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Institution>> GetInstitution(Guid id)
        {
            return await _context.Institutions.FindAsync(id);
        }
    }
}