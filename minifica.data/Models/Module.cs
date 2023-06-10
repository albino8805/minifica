using System.ComponentModel.DataAnnotations;

namespace minifica.data.Models
{
    public class Module : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(350)]
        public string Description { get; set; } = null!;
    }
}
