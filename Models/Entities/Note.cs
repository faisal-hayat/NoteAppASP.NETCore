using System.ComponentModel.DataAnnotations;

namespace NoteApp.Models.Entities
{
    public class Note
    {        
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }
    }
}
