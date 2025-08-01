using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SampleStore.DataAccess;
using SampleStore.Domain.Entities;
using SampleStore.Services.Books;
using SampleStore.Services.Helpers;
using SampleStore.Services.ShoppingCart;
using SampleStore.Services.ShoppingCarts;

namespace SampleStore.Web.Extensions
{
    public static class ServiceConfigureExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));

            services.AddScoped<IBooksService, BooksService>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();
            services.AddScoped<ICartCalculationService, CartCalculationService>();

            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = true;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddErrorDescriber<CustomIdentityErrorDescriber>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddUserStore<UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, Guid>>()
                .AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, Guid>>()
                .AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });

            services.AddAuthorization(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser().Build();
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
            });

            return services;
        }
    }
}
