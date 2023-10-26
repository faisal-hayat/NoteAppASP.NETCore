using Microsoft.EntityFrameworkCore;
using NoteApp.Models.Entities;

namespace NoteApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        // This is where we will be adding the models
        public DbSet<Note> Notes { get; set; }
    }
}
