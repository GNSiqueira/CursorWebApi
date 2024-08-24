using Microsoft.EntityFrameworkCore;
using RezerveiAPI.Objects.Models.Entities;

namespace RezerveiAPI.Contexts.Builders
{
    public class UseBuilder
    {
        public static void Build(ModelBuilder modelBuilder)
        {
            //Builder
            modelBuilder.Entity<UseModel>().HasKey(u => u.Id);
            modelBuilder.Entity<UseModel>().Property(u => u.ImageProfile);
            modelBuilder.Entity<UseModel>().Property(u => u.NameUser).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<UseModel>().Property(u => u.EmailUser).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<UseModel>().Property(u => u.PasswordUser).HasMaxLength(256).IsRequired();
            modelBuilder.Entity<UseModel>().Property(u => u.PhoneUser).HasMaxLength(100).IsRequired();

            //Insersões
            modelBuilder.Entity<UseModel>().HasData(
                new UseModel
                {
                    Id = 1,
                    NameUser = "Master", 
                    EmailUser = "master@development.com", 
                    PasswordUser = "password",
                    PhoneUser = "",
                    ImageProfile = ""
                }    
            )
        }
    }
}
