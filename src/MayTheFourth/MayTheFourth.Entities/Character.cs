namespace MayTheFourth.Entities
{
    public class Character : BaseModel
    {
        public Character()
        {
            Movies = [];
        }

        public string Name { get; set; } = string.Empty;
        public string Height { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string HairColor { get; set; } = string.Empty;
        public string SkinColor { get; set; } = string.Empty;
        public string EyeColor { get; set; } = string.Empty;
        public string BirthYear { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public Guid PlanetId { get; set; }
        public virtual Planet? Planet { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
