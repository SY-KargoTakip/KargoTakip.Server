using KargoTakip.Server.Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace KargoTakip.Server.WebAPI;

public static class ExtensionsMiddleware
{
    public static void CreateFirstUser(WebApplication app)
    {
        using (var scoped = app.Services.CreateScope())
        {
            var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

            if (!userManager.Users.Any(p => p.UserName == "admin"))
            {
                AppUser user = new()
                {
                    Id = Guid.Parse("451b794c-2c4d-43fe-b74a-29019ee5cc2b"),
                    UserName = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Salih",
                    LastName = "YILDIZ",
                    EmailConfirmed = true,
                    CreateAt = DateTimeOffset.Now,
                };

                user.CreateUserId = user.Id;

                userManager.CreateAsync(user, "Aa123456").Wait();


            }
        }
    }


}
