using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotePad.Data;


using NotePad.Entities;

namespace NotePad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        

        public NotesController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var notes = await db.Notes.ToListAsync();
            return Ok(notes);
                
        }
        [HttpGet("Id")]
        public async Task<IActionResult> GetById(int id)
        {
            var note = await db.Notes.FindAsync(id);
            return Ok(note);

        }
        [HttpPost]
        public async Task<IActionResult> Add(Note note)
        {
         
            var n = await db.Notes.AddAsync(note);
            db.SaveChanges();
            return Ok(note);

        }
        [HttpPut]
        public async Task<IActionResult> Update(Note note)
        {

            var e = await db.Notes.SingleOrDefaultAsync(x => x.Id == note.Id);
            e.Name= note.Name;
            db.SaveChanges();
            return Ok(note);

        }
        [HttpDelete]
        public async Task<IActionResult> Remove(Note note)
        {

            var e = await db.Notes.SingleOrDefaultAsync(x => x.Id == note.Id);
            e.Name = note.Name;
            db.Remove(e);
            db.SaveChanges();
            return Ok(note);

        }


    }
}
