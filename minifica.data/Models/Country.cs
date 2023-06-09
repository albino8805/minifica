using System.ComponentModel.DataAnnotations;

namespace minifica.data.Models
{
    public class Country : BaseEntity
	{
		[Required]
		[MaxLength(150)]
		public string Name { get; set; }
	}
}
