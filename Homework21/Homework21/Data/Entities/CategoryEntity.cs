namespace Homework21.Data.Entities
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public List<PetEntity>? Pets { get; set; } = new List<PetEntity>();
        public List<BreedEntity>? Breeds { get; set; } = new List<BreedEntity>();
    }
}
