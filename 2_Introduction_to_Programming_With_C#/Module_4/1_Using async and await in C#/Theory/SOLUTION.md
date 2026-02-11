# Activity: Using async and await in C# - Answer Key

## Step 2: Creating an Asynchronous Method

```csharp
public class Program
{
    public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started...");
        await Task.Delay(3000);
        Console.WriteLine("Download completed.");
    }
}
```

---

## Step 3: Running the Asynchronous Method

```csharp
public class Program
{
    public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started...");
        await Task.Delay(3000);
        Console.WriteLine("Download completed.");
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program();
        await program.DownloadDataAsync();
        Console.WriteLine("Main method completed.");
    }
}
```

**Code File:** See [Step3_AsyncBasic.cs](Steps/Step3_AsyncBasic.cs)

---

## Step 4: Running Multiple Asynchronous Methods in Parallel

```csharp
public class Program
{
    public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started...");
        await Task.Delay(3000);
        Console.WriteLine("Download completed.");
    }

    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Download 2 started...");
        await Task.Delay(2000);
        Console.WriteLine("Download 2 completed.");
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program();
        Task task1 = program.DownloadDataAsync();
        Task task2 = program.DownloadDataAsync2();
        await Task.WhenAll(task1, task2);
        Console.WriteLine("All downloads completed.");
    }
}
```

**Code File:** See [Step4_AsyncParallel.cs](Steps/Step4_AsyncParallel.cs)

---

## Step 5: Handling Exceptions in Asynchronous Methods

```csharp
public class Program
{
    public async Task DownloadDataAsync()
    {
        try
        {
            Console.WriteLine("Download started...");
            throw new InvalidOperationException("Simulated download error.");
            await Task.Delay(3000);
            Console.WriteLine("Download completed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Download 2 started...");
        await Task.Delay(2000);
        Console.WriteLine("Download 2 completed.");
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program();
        Task task1 = program.DownloadDataAsync();
        Task task2 = program.DownloadDataAsync2();
        await Task.WhenAll(task1, task2);
        Console.WriteLine("All downloads completed.");
    }
}
```

**Code File:** See [Step5_AsyncErrorHandling.cs](Steps/Step5_AsyncErrorHandling.cs)
