namespace Backend.Entities
{
    public class Room
    {
        public Guid RoomId { get; set; }
        public int RoomCode { get; set; }
        public Guid RoomCategoryId { get; set; }
        public int Status { get; set; }
        public bool Availability { get; set; }
    }
}
