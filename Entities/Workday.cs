namespace Domain.Entities;

public class Workday : Entity 
{
    public Guid EmployeeId { get; set; }
    public DateTime Date { get; set; }
    public Sign Sign { get; set;} = Sign.Weekend;
}