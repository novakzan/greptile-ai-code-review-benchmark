using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Api.Models;

public class Payment
{
    public int Id { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [MaxLength(50)]
    public string Method { get; set; } = string.Empty;

    [MaxLength(50)]
    public string Status { get; set; } = "Pending";

    [MaxLength(100)]
    public string TransactionId { get; set; } = string.Empty;

    [MaxLength(20)]
    public string CardLastFour { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
