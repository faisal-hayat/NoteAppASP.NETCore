using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteApp.Data;
using NoteApp.Models.Entities;

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
        #region Get All
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // get all notes from database
            if (_dbContext.Notes != null)
            {
                var obj = await _dbContext.Notes.ToListAsync();
                if (obj == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(obj);
                }
            }
            else
            {
                return NotFound();
            }
        }
        #endregion

        #region Get By ID
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            if (_dbContext.Notes == null || id == null)
            {
                return BadRequest("either notes does not exist or id is not correct");
            }
            else
            {
                Note note = await _dbContext.Notes.FirstOrDefaultAsync(u => u.Id == id);
                if (note == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(note);
                }
            }
            #endregion
        }
    }
}