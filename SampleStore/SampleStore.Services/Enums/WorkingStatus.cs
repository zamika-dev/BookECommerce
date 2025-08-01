using System.ComponentModel.DataAnnotations;

namespace SampleStore.Domain.Enums
{
    public enum Condition
    {
        [Display(Name = "نو")]
        New = 1,
        [Display(Name = "درحد نو")]
        LikeNew = 2,
        [Display(Name = "کارکرده")]
        Used = 3
    }
}
