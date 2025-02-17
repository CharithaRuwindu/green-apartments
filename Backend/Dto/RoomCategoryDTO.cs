namespace Backend.Models
{
    public class RoomCategoryDTO
    {
        public Guid CategoryId { get; set; }
        public String CategoryName { get; set; }
        public int Occupancy { get; set; }
        public int Size { get; set; }
        public String Intro { get; set; }
        public String View { get; set; }
        public String Description { get; set; }
        public String Amenities { get; set; }
        public String OtherAmenities { get; set; }
        public String Price { get; set; }
        public Boolean IsActive { get; set; }

    }
}
