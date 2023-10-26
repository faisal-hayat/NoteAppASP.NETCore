using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteApp.Data;

namespace NoteApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public NotesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // get all notes from database
            if (_dbContext.Notes != null)
            {
                var obj = await _dbContext.Notes.ToListAsync();
                return Ok(obj);
            }
            else
            {
                return BadRequest("No Notes exist in database.");
            }
        }
    }
}