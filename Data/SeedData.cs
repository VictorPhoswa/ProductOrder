using Microsoft.EntityFrameworkCore;
using ProductStore.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Text;

namespace ProductStore.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
        serviceProvider.GetRequiredService<
            DbContextOptions<ApplicationDbContext>>()))
        {
            context.Database.EnsureCreated();
            var dataStream = new MemoryStream();

            // Look for any Products
            if (!context.Products.Any())
            {
                context.Products.AddRange(

                new Product
                {
                    ShortDescription = "Toshiba 32\" V35MN HD Smart LED TV with Digital Tuner & Dolby Audio",
                    LongDescription = "Samsung 55\" QE1 4K QLED Smart TV with Game Motion Plus",
                    Price = 29.99M,
                    PreviewIage = Encoding.UTF8.GetBytes("/css/Images/Books.jpg").ToArray(),
                    inStock = 10,
                    CategoryId = 1
                },
                new Product
                {
                    ShortDescription = "LG 65\" NANO776 4K UHD Smart TV",
                    LongDescription = "Hisense 65\" U6K 4K Smart ULED TV with Quantum Dot & HDR",
                    Price = 29.99M,
                    PreviewIage = Encoding.UTF8.GetBytes("C:\\Users\\Victor Maqina Phoswa\\Downloads\\Orders.png"),
                    inStock = 5,
                    CategoryId = 1
                },
                new Product
                {
                    ShortDescription = "JBL Go 3 Waterproof Portable Bluetooth Speaker",
                    LongDescription = "Volkano Bluetooth Speaker Stun Series - Black",
                    Price = 29.99M,
                    PreviewIage = Encoding.UTF8.GetBytes("C:\\Users\\Victor Maqina Phoswa\\Downloads\\Orders.png"),
                    inStock = 5,
                    CategoryId = 1
                },
                new Product
                {
                    ShortDescription = "Volkano Bluetooth Speaker Stun Series - Black",
                    LongDescription = "Mondi Rotatrim Box of A4 Paper",
                    Price = 29.99M,
                    PreviewIage = Encoding.UTF8.GetBytes("C:\\Users\\Victor Maqina Phoswa\\Downloads\\Orders.png"),
                    inStock = 5,
                    CategoryId = 1
                },
                new Product
                {
                    ShortDescription = "Treeline Hard Cover Book 2 Quire A4 192pg - Feint & Margin (Pack of 5)",
                    LongDescription = "Volkano Wireless Bluetooth Headphones - Phonic Series - Rose Gold",
                    Price = 29.99M,
                    PreviewIage = Encoding.UTF8.GetBytes("C:\\Users\\Victor Maqina Phoswa\\Downloads\\Orders.png"),
                    inStock = 5,
                    CategoryId = 1
                },
                new Product
                {
                    ShortDescription = "Samsung Galaxy A04e 32GB LTE Dual Sim - Black",
                    LongDescription = "Xiaomi Redmi A2 32GB Dual Sim - Blue",
                    Price = 29.99M,
                    PreviewIage = Encoding.UTF8.GetBytes("C:\\Users\\Victor Maqina Phoswa\\Downloads\\Orders.png"),
                    inStock = 5,
                    CategoryId = 1
                },
                new Product
                {
                    ShortDescription = "Hisense E32 Lite - LTE Dual SIM - Blue (NL) + MTN SIM KIT & LTE Device Promotion",
                    LongDescription = "Xiaomi Redmi A2 32GB Dual Sim - Blue",
                    Price = 29.99M,
                    PreviewIage = Encoding.UTF8.GetBytes("C:\\Users\\Victor Maqina Phoswa\\Downloads\\Orders.png"),
                    inStock = 5,
                    CategoryId = 1
                },
                new Product
                {
                    ShortDescription = "Typek A4 White Copier Paper - 1 Box",
                    LongDescription = "Typek A4 White Copier Paper - 1 Box",
                    Price = 29.99M,
                    PreviewIage = Encoding.UTF8.GetBytes("C:\\Users\\Victor Maqina Phoswa\\Downloads\\Orders.png"),
                    inStock = 5,
                    CategoryId = 1
                }


                );

                context.SaveChanges();
            }

        }
    }
}
