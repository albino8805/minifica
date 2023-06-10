using System.ComponentModel.DataAnnotations;

namespace minifica.data.Models
{
    public class Action : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
    }
}
