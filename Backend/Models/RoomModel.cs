using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class RoomModel
    {
        [Required, MaxLength(2)]
        public int RoomCode { get; set; }
        [Required]
        public Guid RoomCategoryId { get; set; }
    }
}
