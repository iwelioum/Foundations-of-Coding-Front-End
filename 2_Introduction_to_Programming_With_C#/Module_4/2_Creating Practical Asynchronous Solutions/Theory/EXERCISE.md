# Activity: Creating Practical Asynchronous Solutions

## Objective

Apply `async` and `await` in practical scenarios, such as fetching data and handling multiple asynchronous tasks concurrently.

## Description

This activity provides learners with code examples illustrating the use of async and await in practical scenarios, such as fetching data and handling multiple asynchronous tasks. The examples demonstrate best practices in asynchronous programming and show how these techniques can improve user experiences. After reviewing the examples, learners will apply these concepts to solve additional problems.

## Set Up Your Environment

1. Use the Visual Studio Code console application you created at the start of the course. Remove any existing code in the `Program.cs` file of your console application.
2. Copy and edit the code in this activity into the `Program.cs` file to complete the steps.

---

## Example 1: Fetching Product Data Asynchronously

### Problem

Simulate a scenario where an application fetches a list of products from a remote server. The fetching process takes time, so it should be done asynchronously to avoid blocking the main thread.

```csharp
public class Product
{
    public string Name { get; set; }

    public Product(string name)
    {
        Name = name;
    }
}

public class Program
{
    // Asynchronous method to fetch product data
    public async Task<List<Product>> FetchProductsAsync()
    {
        await Task.Delay(2000); // Simulating a 2-second delay for data fetching
        return new List<Product>
        {
            new Product("Eco Bag"),
            new Product("Reusable Straw")
        };
    }

    // Asynchronous method to display product data
    public async Task DisplayProductsAsync()
    {
        List<Product> products = await FetchProductsAsync();
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
        }
    }

    // Main entry point
    public static async Task Main(string[] args)
    {
        Program program = new Program();
        await program.DisplayProductsAsync();
    }
}
```

### Steps Explained

1. **Define an Asynchronous Method (FetchProductsAsync):** The `async` keyword indicates it is asynchronous. `Task.Delay(2000)` simulates an API call that takes 2 seconds. The method returns a list of `Product` objects.
2. **Define an asynchronous method to DisplayProductsAsync:** The `await` keyword waits for `FetchProductsAsync` to complete before proceeding. The main thread remains responsive during the data-fetching process.
3. **Calling the Asynchronous Method in Main:** `await program.DisplayProductsAsync()` ensures the program waits for the data to be displayed before exiting.

**Code File:** See [Example1_FetchProducts.cs](Examples/Example1_FetchProducts.cs)

---

## Example 2: Running Multiple Asynchronous Tasks Concurrently

### Problem

Extend the previous example to fetch both products and reviews asynchronously, simulating a scenario where an application needs to handle multiple data sources at the same time.

```csharp
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
```

### Steps Explained

1. **Define a Review Class:** A new `Review` class is added, similar to the `Product` class.
2. **Run Multiple Async Methods:** Start both tasks concurrently without waiting for each to finish sequentially. Use `Task.WhenAll` to ensure both tasks complete before processing the results.
3. **Accessing the Results:** Use the `.Result` property to get the data after both tasks finish.
4. **Displaying the Data:** Print the fetched products and reviews to the console.

**Code File:** See [Example2_ConcurrentFetch.cs](Examples/Example2_ConcurrentFetch.cs)

---

## Problems to Complete

### Problem 1: Downloading Files Asynchronously

In the code provided, some of the keywords related to asynchronous programming in C# have been removed. Your task is to fill in the blanks (`_____`) with the correct `async` or `await` keywords to make the code function properly.

- Use `async` where you need to indicate that a method is asynchronous.
- Use `await` where you need to wait for an asynchronous operation to complete.

**Remember:**
- Methods that return `Task` or `Task<T>` should be marked with the `async` keyword.
- Operations that need to be awaited must have the `await` keyword before them.

### Starter Code

```csharp
public class Program
{
    public _____ Task<string> DownloadFileAsync(string fileName)
    {
        Console.WriteLine($"Starting download of {fileName}...");
        _____ Task.Delay(3000); // Simulate a 3-second download time
        Console.WriteLine($"Completed download of {fileName}.");
        return $"{fileName} content";
    }

    public _____ Task DownloadFilesAsync()
    {
        // Start downloading "File1.txt" and "File2.txt" concurrently
        var downloadTask1 = DownloadFileAsync("File1.txt");
        var downloadTask2 = DownloadFileAsync("File2.txt");

        // Wait for both downloads to complete
        _____ Task.WhenAll(downloadTask1, downloadTask2);
        Console.WriteLine("All downloads completed.");
    }

    public static _____ Task Main(string[] args)
    {
        Program program = new Program();
        _____ program.DownloadFilesAsync();
    }
}
```

---

### Problem 2: Processing Data Chunks Asynchronously

In the code provided, some of the asynchronous programming keywords have been removed. Your task is to correctly fill in the blanks (`_____`) using either `async` or `await` based on the context.

### Starter Code

```csharp
public class Program
{
    public _____ Task ProcessDataChunkAsync(int chunkNumber)
    {
        Console.WriteLine($"Processing chunk {chunkNumber}...");
        _____ Task.Delay(1000); // Simulate processing time
        Console.WriteLine($"Completed processing of chunk {chunkNumber}.");
    }

    public _____ Task ProcessLargeDatasetAsync(int numberOfChunks)
    {
        var tasks = new List<Task>();

        // Start processing each chunk concurrently
        for (int i = 1; i <= numberOfChunks; i++)
        {
            tasks.Add(ProcessDataChunkAsync(i));
        }

        // Wait for all tasks to complete
        _____ Task.WhenAll(tasks);

        Console.WriteLine("All data chunks processed.");
    }

    public static _____ Task Main(string[] args)
    {
        Program program = new Program();
        _____ program.ProcessLargeDatasetAsync(5); // Process 5 chunks
    }
}
```
