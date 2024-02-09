using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NSKStore.Data;
using System;
using System.Linq;

namespace NSKStore.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new NSKStoreContext(
        serviceProvider.GetRequiredService<DbContextOptions<NSKStoreContext>>()))
        {
            if (context.Products.Any()) 
            {
                return;
            }
            context.Products.AddRange(
                new Products
                {
                    Name = "Saji cooking oil(2kg)",
                    Price = 15.90M,
                    ImagePath = "~/Images/Products/Saji2KG.png",
                    Category = "Dry Ingredients",
                    Stock = 100
                },
                new Products
                {
                    Name = "Life Chilli Sauce (725g)",
                    Price = 6.70M,
                    ImagePath = "~/Images/Products/Life_Chilli_Sauce.png",
                    Category = "Sauces",
                    Stock = 50
                },
                new Products
                {
                    Name = "Cap Sauh Wheat Flour Tepung Gandum (1kg)",
                    Price = 3.70M
                },
                new Products
                {
                    Name = "Hup Seng Cream Crackers (428g)",
                    Price = 5.88M
                },
                new Products
                {
                    Name = "Nestle Nestum 3-In-1 Original (28g x 15)",
                    Price = 14.64M
                }
            );
            context.SaveChanges();
        }
    }
}
