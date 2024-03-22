namespace Homework21.Data.Entities
{
    public class PetEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? CategoryId { get; set; }
        public int? BreedId { get; set; }
        public float? Age { get; set; }
        public int? LocationId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public BreedEntity Breed { get; set; }
        public LocationEntity Location { get; set; }
        public CategoryEntity Category { get; set; }
    }
}
