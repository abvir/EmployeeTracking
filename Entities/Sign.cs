namespace Domain.Entities;

public class Sign
{
    public string Liter { get; set; } = string.Empty;
    public double HourDay { get; set; } = 0;
    public double HourEvening { get; set; } = 0;
    public double HourNight { get; set; } = 0;
    public double HourTotal => HourDay + HourEvening + HourNight;

    public static Sign Weekend => new() { Liter = "В"};
}