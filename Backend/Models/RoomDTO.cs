namespace Backend.Models
{
    public class RoomDTO
    {
        public Guid RoomId { get; set; }
        public int RoomCode { get; set; }
        public Guid RoomCategoryId { get; set; }
        public int Status { get; set; }
        public Boolean Availability { get; set; }
    }
}
