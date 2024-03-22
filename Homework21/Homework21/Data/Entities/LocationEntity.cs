namespace Homework21.Data.Entities
{
    public class LocationEntity
    {
        public int Id { get; set; }
        public string LocationName { get; set; } = string.Empty;
        public List<PetEntity>? Pets { get; set; } = new List<PetEntity>();
    }
}
