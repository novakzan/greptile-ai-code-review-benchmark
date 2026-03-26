using System.ComponentModel.DataAnnotations;

namespace ECommerce.Api.Models;

public class EmailTemplate
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(200)]
    public string Subject { get; set; } = string.Empty;

    [MaxLength(5000)]
    public string HtmlBody { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
