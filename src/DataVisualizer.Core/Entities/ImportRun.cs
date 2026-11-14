namespace DataVisualizer.Core.Entities;

public class ImportRun
{
    public int Id { get; set; }
    public string Source { get; set; } = "";
    public DateTime StartedAt { get; set; }
    public DateTime? FinishedAt { get; set; }
    public string Status { get; set; } = "Running";   // Running, Succeeded, Failed
    public int RowsRead { get; set; }
    public int RowsInserted { get; set; }
    public int RowsUpdated { get; set; }
    public string? Error { get; set; }
}