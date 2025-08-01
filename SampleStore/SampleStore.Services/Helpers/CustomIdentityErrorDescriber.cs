using Microsoft.AspNetCore.Identity;

namespace SampleStore.Services.Helpers
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        => new IdentityError { Code = nameof(PasswordTooShort), Description = $"رمز عبور باید حداقل {length} کاراکتر باشد." };

        public override IdentityError PasswordRequiresDigit()
            => new IdentityError { Code = nameof(PasswordRequiresDigit), Description = "رمز عبور باید شامل حداقل یک عدد باشد." };

        public override IdentityError DuplicateUserName(string userName)
            => new IdentityError { Code = nameof(DuplicateUserName), Description = $"نام کاربری '{userName}' قبلاً ثبت شده است." };

        public override IdentityError DuplicateEmail(string email)
            => new IdentityError { Code = nameof(DuplicateEmail), Description = $"ایمیل '{email}' قبلاً ثبت شده است." };
    }
}
