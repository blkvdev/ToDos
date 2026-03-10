using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToDoPlatform.Models;

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

        #region  Popular dados de Usuário
        List<AppUser> users = new()
        {
            new AppUser()
            {
                Id = "0a1d1605-71d1-4ea5-8940-c75234d82850",
                Email = "rafaelaangelinaaa@gmail.com",
                NormalizedEmail = "RAFAELAANGELINAAA@GMAIL.COM",
                UserName = "rafaelaangelinaaa@gmail.com",
                NormalizedUserName = "RAFAELAANGELINAAA@GMAIL.COM",
                LockoutEnabled = false,
                EmailConfirmed = true,
                Name = "Rafaela Angelina Souza",
                ProfilePicture = "/img/users/0a1d1605-71d1-4ea5-8940-c75234d82850.png"
            },

            new AppUser()
            {
                Id = "c9a69c72-4c02-4702-84a8-f60f9323069d",
                Email = "carlosfilhocontato2008@gmail.com",
                NormalizedEmail = "CARLOSFILHOCONTATO2008@GMAIL.COM",
                UserName = "carlosfilhocontato2008@gmail.com",
                NormalizedUserName = "CARLOSFILHOCONTATO2008@GMAIL.COM",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Name = "Carlos Alberto Pinheiro Filho",
                ProfilePicture = "/img/users/0a1d1605-71d1-4ea5-8940-c75234d82850.png"
            },

        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "123456");
        }
        builder.Entity<AppUser>().HasData(users);
        #endregion

        #region Popular Dados de Usuário Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            
            new IdentityUserRole<string>()
            {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>()
            {
                UserId = users[1].Id,
                RoleId = roles[1].Id
            },
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion

        #region Popular as Tarefas do usuário
        List<ToDo> toDos = new()
        {
            new ToDo()
            {
                Id = 1,
                Title = "Lava a louça hoje",
                Description = "Minha mãe me obriga",
                UserID = users[1].Id
            },
            new ToDo()
            {
                Id = 2,
                Title = "Coloca comida pros cachorro",
                Description = "Precisa come né",
                UserID = users[1].Id
            },
            new ToDo()
            {
                Id = 3,
                Title = "Recolher a roupa no varal",
                Description = "Se chove molha",
                UserID = users[1].Id
            },
        };
        builder.Entity<ToDo>().HasData(toDos);
        #endregion
    }

    
} 
