namespace minifica.data.Models
{
    public class Profile: BaseEntity
    {
        public string Name { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set;}
    }
}
