using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ToDoPlatform.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Popular Perfis de usuários
        List<IdentityRole> roles = new()
        {
            new()
            {
                Id = "139eeec0-7e9a-469c-aa0a-1db824d909c0",
                Name = "Administrador", 
                NormalizedName = "ADMINISTRADOR"
            },
            new()
            {
                Id = "f4ba46a6-42a7-4224-8ecd-ea9ef6a41256",
                Name = "Usuário", 
                NormalizedName = "USUÁRIO"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Popular Usuário

        #endregion
    }
}
