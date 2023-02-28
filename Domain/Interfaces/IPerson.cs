namespace Domain.Interfaces
{
    public interface IPerson
    {
        Guid Id { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        string PassportId { get; set; }
    }
}
