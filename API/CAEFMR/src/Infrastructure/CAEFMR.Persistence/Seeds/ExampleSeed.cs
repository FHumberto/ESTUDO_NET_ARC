using Microsoft.EntityFrameworkCore;
using CAEFMR.Domain.Entities;

namespace CAEFMR.Persistence.Seeds
{
    public static class ExampleSeed
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Example>().HasData(
                new Example { Id = 1, Nome = "Exemplo 1", Preco = 10.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 2, Nome = "Exemplo 2", Preco = 20.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 3, Nome = "Exemplo 3", Preco = 15.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 4, Nome = "Exemplo 4", Preco = 25.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 5, Nome = "Exemplo 5", Preco = 30.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 6, Nome = "Exemplo 6", Preco = 40.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 7, Nome = "Exemplo 7", Preco = 50.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 8, Nome = "Exemplo 8", Preco = 60.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 9, Nome = "Exemplo 9", Preco = 70.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 10, Nome = "Exemplo 10", Preco = 80.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 11, Nome = "Exemplo 11", Preco = 90.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 12, Nome = "Exemplo 12", Preco = 100.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 13, Nome = "Exemplo 13", Preco = 110.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 14, Nome = "Exemplo 14", Preco = 120.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Example { Id = 15, Nome = "Exemplo 15", Preco = 130.99m, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}