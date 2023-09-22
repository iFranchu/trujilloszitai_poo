using System;
namespace steam
{
    class Program
    {
        static void Main(string[] args)
        {
            Platform steam = new Platform("Steam");
            List<Product> myProducts = new List<Product>();
            List<User> myUsers = new List<User>();

            Random r = new Random();
            Array gameCtgryValues = Enum.GetValues(typeof(VideogameCategory));
            Array appCtgryValues = Enum.GetValues(typeof(SoftwareCategory));

            for (int i = 1; i < 11; i++)
            {
                bool randomBoolean = r.Next(2) == 1;
                Date randomDate = new Date(r.Next(1, 30), r.Next(1, 13), 2023);
                VideogameCategory gameCategory = (VideogameCategory)gameCtgryValues.GetValue(r.Next(gameCtgryValues.Length));
                SoftwareCategory appCategory = (SoftwareCategory)appCtgryValues.GetValue(r.Next(appCtgryValues.Length));

                Videogame newGame = new Videogame(name: $"videogame{i}", price: i * 10, earlyAccess: randomBoolean, score: i, minimumAge: r.Next(8, 19), category: gameCategory);
                Application newApp = new Application(name: $"application{i}", price: i * 2, earlyAccess: randomBoolean, score: i, category: appCategory);
                User newUser = new User($"user{i}", r.Next(16, 50), r.NextDouble() * 1000); 
                Review newReview = new Review($"title{i}", $"content{i}", newUser, randomBoolean, randomDate);

                newGame.Reviews.Add(newReview);
                newApp.Reviews.Add(newReview);

                myProducts.Add(newGame);
                myProducts.Add(newApp);
                myUsers.Add(newUser);
            }

            steam.Products.AddRange(myProducts);
            steam.Users.AddRange(myUsers);

            Console.WriteLine($"La plataforma {steam.Name} tiene {steam.Products.Count} productos y {steam.Users.Count} usuarios");
            Console.WriteLine();
            foreach(Product product in steam.Products) {
                Console.WriteLine(product.ToString());
            }

            Console.ReadKey();
        }
    }
}
