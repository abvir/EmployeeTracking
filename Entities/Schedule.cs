namespace Domain.Entities;

public class Schedule : Entity
{   
    public string ScheduleName { get; set; } = string.Empty;
    public string BrigadeName { get; set; } = string.Empty;
    public List<Sign> Signs { get; set; } = [];
    public Repeat Repeat { get; set; }
}
