// See https://aka.ms/new-console-template for more information



using Animals.Migrations;
using Animals.Models;

var ctx = new DbContextAnimals();



Cart cart1 = new Cart();
cart1.CustomerId = 11;
cart1.ProductCarts = new List<ProductCart> { new ProductCart { ProductId = 6, CartId = 1 }, { new ProductCart { ProductId = 8, CartId = 1 } } };
ctx.Add(cart1);
ctx.SaveChanges();
