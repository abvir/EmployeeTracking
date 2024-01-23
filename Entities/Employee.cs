namespace Domain.Entities;

public class Employee : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Patronymic { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public Guid DefaultScheduleId { get; set; }
}
