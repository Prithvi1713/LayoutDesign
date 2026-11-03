namespace LayoutDesign.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool  => !string.IsNullOrEmpty(RequestId);
    }
}
