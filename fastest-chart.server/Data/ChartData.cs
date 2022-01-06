namespace fastest_chart.server.Data;

public class ChartData
{
    public Guid OrderId { get; set; } = Guid.NewGuid();
    public string Range { get; set; }
    public decimal HoursAvailable { get; set; }
    public decimal HoursRequired { get; set; }
    public decimal QtyAvailable { get; set; }
    public decimal QtyRequired  { get; set; }
}