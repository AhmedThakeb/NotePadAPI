using System.ComponentModel.DataAnnotations;

namespace NotePad.Entities
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? LastUpDate { get; set; }
    }
}
