using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Api.Models;

public class SalesReport
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string ReportName { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalRevenue { get; set; }

    public int TotalOrders { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal AverageOrderValue { get; set; }

    public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;
}
