namespace SampleStore.Domain.Entities
{
    public class City
    {
        public Guid Id { get; set; }
        public string CityName { get; set; } = string.Empty;
        public Guid ProvinceId { get; set; }
        public Province? Province { get; set; }
    }
}
