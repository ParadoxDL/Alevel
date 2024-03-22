namespace Homework21.Data.Entities
{
    public class BreedEntity
    {
        public int Id { get; set; }
        public string BreedName { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; } = null!;
        public List<PetEntity>? Pets { get; set; } = new List<PetEntity>();
    }
}
