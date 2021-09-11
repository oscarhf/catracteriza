using System;
using AbastFacto.App.Shared;
using Microsoft.EntityFrameworkCore;

namespace AbastFacto.App.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<CharacterizationFactor> Factors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*        base.OnModelCreating(modelBuilder);
                    modelBuilder.Entity<CharacterizationFactor>().HasData(new CharacterizationFactor
                    {
                        FactorId = 1,
                        ShortName = "Costos Producción Cultivos",
                        Metric = "$/Ha"
                    });

                    modelBuilder.Entity<CharacterizationFactor>().HasData(new CharacterizationFactor
                    {
                        FactorId = 2,
                        ShortName = "Precios de la tierra",
                        Metric = "$/Ha"
                    });
                    modelBuilder.Entity<CharacterizationFactor>().HasData(new CharacterizationFactor
                    {
                        FactorId = 3,
                        ShortName = "Hectáreas Cultivadas",
                        Metric = "Ha"
                    });

                    modelBuilder.Entity<CharacterizationFactor>().HasData(new CharacterizationFactor
                    {
                        FactorId = 4,
                        ShortName = "Disponibilidad de Terrenos",
                        Metric = "Ha"
                    });
                    modelBuilder.Entity<CharacterizationFactor>().HasData(new CharacterizationFactor
                    {
                        FactorId = 5,
                        ShortName = "Calidad de Vida",
                        Metric = "Index NBI"
                    });
                    modelBuilder.Entity<CharacterizationFactor>().HasData(new CharacterizationFactor
                    {
                        FactorId = 6,
                        ShortName = "Disponibilidad de Terrenos",
                        Metric = "%"
                    });
        */
        }


    }
}