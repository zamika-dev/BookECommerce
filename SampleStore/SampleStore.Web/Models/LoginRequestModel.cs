using System.ComponentModel.DataAnnotations;

namespace SampleStore.Web.Models
{
    public class LoginRequestModel
    {
        [Required(ErrorMessage = "این فیلد نمی تواند خالی باشد")]
        [EmailAddress(ErrorMessage = "ایمیل نامعتبر است")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "این فیلد نمی تواند خالی باشد")]
        public required string Password { get; set; }
    }
}
