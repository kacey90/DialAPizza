namespace BlazingPizza.Server
{
    public static class SeedData
    {
        public static void Initialize(PizzaStoreContext db)
        {
            var toppings = new Topping[]
            {
                new Topping()
                {
                    Name = "Extra cheese",
                    Price = 350.00m,
                },
                new Topping()
                {
                    Name = "American bacon",
                    Price = 355.99m,
                },
                new Topping()
                {
                    Name = "British bacon",
                    Price = 259.99m,
                },
                new Topping()
                {
                    Name = "Canadian bacon",
                    Price = 249.99m,
                },
                new Topping()
                {
                    Name = "Tea and crumpets",
                    Price = 400.00m
                },
                new Topping()
                {
                    Name = "Fresh-baked scones",
                    Price = 399.50m,
                },
                new Topping()
                {
                    Name = "Bell peppers",
                    Price = 200.00m,
                },
                new Topping()
                {
                    Name = "Onions",
                    Price = 200.00m,
                },
                new Topping()
                {
                    Name = "Mushrooms",
                    Price = 150.00m,
                },
                new Topping()
                {
                    Name = "Pepperoni",
                    Price = 150.00m,
                },
                new Topping()
                {
                    Name = "Duck sausage",
                    Price = 400.00m,
                },
                new Topping()
                {
                    Name = "Venison meatballs",
                    Price = 379.99m,
                },
                new Topping()
                {
                    Name = "Served on a silver platter",
                    Price = 1550.99m,
                },
                new Topping()
                {
                    Name = "Lobster on top",
                    Price = 2500.00m,
                },
                new Topping()
                {
                    Name = "Sturgeon caviar",
                    Price = 800.75m,
                },
                new Topping()
                {
                    Name = "Artichoke hearts",
                    Price = 650.00m,
                },
                new Topping()
                {
                    Name = "Fresh tomatoes",
                    Price = 150.00m,
                },
                new Topping()
                {
                    Name = "Basil",
                    Price = 119.99m,
                },
                new Topping()
                {
                    Name = "Steak (medium-rare)",
                    Price = 300.00m,
                },
                new Topping()
                {
                    Name = "Blazing hot peppers",
                    Price = 520.00m,
                },
                new Topping()
                {
                    Name = "Buffalo chicken",
                    Price = 850.00m,
                },
                new Topping()
                {
                    Name = "Blue cheese",
                    Price = 300.00m,
                },
            };

            var specials = new PizzaSpecial[]
            {
                new PizzaSpecial()
                {
                    Name = "Basic Cheese Pizza",
                    Description = "It's cheesy and delicious. Why wouldn't you want one?",
                    BasePrice = 2500.00m,
                    ImageUrl = "img/pizzas/cheese.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 2,
                    Name = "The Baconatorizor",
                    Description = "It has EVERY kind of bacon",
                    BasePrice = 3999.99m,
                    ImageUrl = "img/pizzas/bacon.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 3,
                    Name = "Classic pepperoni",
                    Description = "It's the pizza you grew up with, but Blazing hot!",
                    BasePrice = 5000.50m,
                    ImageUrl = "img/pizzas/pepperoni.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 4,
                    Name = "Buffalo chicken",
                    Description = "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up",
                    BasePrice = 6999.00m,
                    ImageUrl = "img/pizzas/meaty.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 5,
                    Name = "Mushroom Lovers",
                    Description = "It has mushrooms. Isn't that obvious?",
                    BasePrice = 3500.00m,
                    ImageUrl = "img/pizzas/mushroom.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 6,
                    Name = "The Brit",
                    Description = "When in London...",
                    BasePrice = 4500.00m,
                    ImageUrl = "img/pizzas/brit.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 7,
                    Name = "Veggie Delight",
                    Description = "It's like salad, but on a pizza",
                    BasePrice = 3000.50m,
                    ImageUrl = "img/pizzas/salad.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 8,
                    Name = "Margherita",
                    Description = "Traditional Italian pizza with tomatoes and basil",
                    BasePrice = 4699.99m,
                    ImageUrl = "img/pizzas/margherita.jpg",
                },
            };

            db.Toppings.AddRange(toppings);
            db.Specials.AddRange(specials);
            db.SaveChanges();
        }
    }
}
