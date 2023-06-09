namespace minifica.data.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int ProfileFK { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public int CreateBy { get; set; }

        public int UpdateBy { get; set; }
    }
}
