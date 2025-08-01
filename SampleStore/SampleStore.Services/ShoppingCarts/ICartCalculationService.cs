namespace SampleStore.Services.ShoppingCarts
{
    public interface ICartCalculationService
    {
        Task<CartCalculationDto> GetCartSummaryAsync(Guid userId);
    }
}
