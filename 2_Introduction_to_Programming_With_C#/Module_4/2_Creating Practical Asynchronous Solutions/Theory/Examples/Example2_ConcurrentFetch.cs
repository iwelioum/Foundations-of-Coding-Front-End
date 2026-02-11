// Fetching products and reviews concurrently
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Product
{
    public string Name { get; set; }

    public Product(string name)
    {
        Name = name;
    }
}

public class Review
{
    public string Content { get; set; }

    public Review(string content)
    {
        Content = content;
    }
}

public class Program
{
    public async Task<List<Product>> FetchProductsAsync()
    {
        await Task.Delay(2000);
        return new List<Product> { new Product("Eco Bag"), new Product("Reusable Straw") };
    }

    public async Task<List<Review>> FetchReviewsAsync()
    {
        await Task.Delay(3000);
        return new List<Review>
        {
            new Review("Great product!"),
            new Review("Good value for the money."),
        };
    }

    public async Task FetchDataAsync()
    {
        Task<List<Product>> productsTask = FetchProductsAsync();
        Task<List<Review>> reviewsTask = FetchReviewsAsync();

        await Task.WhenAll(productsTask, reviewsTask);

        List<Product> products = await productsTask;
        List<Review> reviews = await reviewsTask;

        Console.WriteLine("Products:");
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
        }

        Console.WriteLine("\nReviews:");
        foreach (Review review in reviews)
        {
            Console.WriteLine(review.Content);
        }
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program();
        await program.FetchDataAsync();
    }
}
