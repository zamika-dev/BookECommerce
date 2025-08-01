namespace SampleStore.Domain.Entities
{
    public class Writer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public Guid? CountryId { get; set; }
        public Country? Country { get; set; }
    }
}
