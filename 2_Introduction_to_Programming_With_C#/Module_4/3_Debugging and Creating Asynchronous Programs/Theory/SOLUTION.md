# Activity: Debugging and Creating Asynchronous Programs - Answer Key

## Step 2: Implementing an Asynchronous Method

```csharp
public class Program
{
    public static async Task PerformLongOperationAsync()
    {
        Console.WriteLine("Operation started...");
        await Task.Delay(3000); // Simulate a delay of 3 seconds
        Console.WriteLine("Operation completed.");
    }
}
```

---

## Step 3: Calling the Async Method in Main

```csharp
public static void Main(string[] args)
{
    // Calling the asynchronous method
    Task.Run(async () => await PerformLongOperationAsync()).Wait();
    Console.WriteLine("Main method completed.");
}
```

**Code File:** See [Step3_AsyncMethod.cs](Steps/Step3_AsyncMethod.cs)

---

## Step 4: Simulating Debugging with Console Statements

```csharp
public static async Task PerformLongOperationAsync()
{
    Console.WriteLine("Operation started..."); // Simulate a breakpoint
    await Task.Delay(3000); // Simulate a delay of 3 seconds
    Console.WriteLine("After await..."); // Simulate a breakpoint
    Console.WriteLine("Operation completed.");
}
```

---

## Step 5: Handling Potential Errors

```csharp
public static async Task PerformLongOperationAsync()
{
    try
    {
        Console.WriteLine("Operation started...");
        await Task.Delay(3000); // Simulate a delay
        throw new InvalidOperationException("Simulated long operation error.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}
```

**Code File:** See [Step5_AsyncWithErrorHandling.cs](Steps/Step5_AsyncWithErrorHandling.cs)
