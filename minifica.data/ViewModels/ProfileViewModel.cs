namespace minifica.data.ViewModels
{
    public class ProfileViewModel: BaseViewModel
    {
        public string Name { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
                       