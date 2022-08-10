using API_TAREFAS.Domain.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TAREFAS.Infra.Data.Context
{
    public class SeedInitial
    {

        public static void Seed(IApplicationBuilder applicationsBuilder)
        {
            using (var serviceScope = applicationsBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();


                context.Database.EnsureCreated();
                //profile ------------------------------------
                if (!context.Profiles.Any())
                {
                    context.Profiles.AddRange(new List<Profile>() {
                        new Profile(){Name = "Admin"},
                        new Profile(){Name = "Manager"},
                        new Profile(){Name = "user"}

                    });
                    context.SaveChanges();
                }


                //User ------------------------------------
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>() {

                        new User()
                        {
                            Name = "Admin",
                            Email = "admin@admin.com",
                            Password = "admin",
                            IsActive = true,
                            CreatAt = DateTime.Now,
                            ProfileId = 1
                        },
                         new User()
                        {
                            Name = "Usuario",
                            Email = "usuario@usuario.com",
                            Password = "usuario",
                            IsActive = true,
                            CreatAt = DateTime.Now,
                           ProfileId = 3
                        }
                    });
                    context.SaveChanges();
                }


            }
        }
    }
}
