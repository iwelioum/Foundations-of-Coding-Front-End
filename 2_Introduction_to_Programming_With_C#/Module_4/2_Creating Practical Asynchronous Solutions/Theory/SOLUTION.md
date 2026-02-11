# Activity: Creating Practical Asynchronous Solutions - Answer Key

## Problem 1: Downloading Files Asynchronously

```csharp
public async Task DownloadFilesAsync()
{
    // Start downloading "File1.txt" and "File2.txt" concurrently
    var downloadTask1 = DownloadFileAsync("File1.txt");
    var downloadTask2 = DownloadFileAsync("File2.txt");

    // Wait for both downloads to complete
    await Task.WhenAll(downloadTask1, downloadTask2);

    Console.WriteLine("All downloads completed.");
}

public static async Task Main(string[] args)
{
    Program program = new Program();
    await program.DownloadFilesAsync();
}
```

### Explanation

- **DownloadFileAsync Method:** This method simulates downloading a file by pausing for 3 seconds. You don't need to change this method.
- **DownloadFilesAsync Method:** You need to complete this method to start downloading two files concurrently by calling `DownloadFileAsync` twice. Use `Task.WhenAll` to ensure both downloads are completed before proceeding.
- **Running the Code:** When you run the `Main` method, it should display messages indicating that the downloads have started and finished, followed by a final message saying all downloads are completed.

**Code File:** See [Solution1_DownloadFiles.cs](Solutions/Solution1_DownloadFiles.cs)

---

## Problem 2: Processing Data Chunks Asynchronously

```csharp
public async Task ProcessLargeDatasetAsync(int numberOfChunks)
{
    var tasks = new List<Task>();

    // Start processing each chunk concurrently
    for (int i = 1; i <= numberOfChunks; i++)
    {
        tasks.Add(ProcessDataChunkAsync(i));
    }

    // Wait for all tasks to complete
    await Task.WhenAll(tasks);

    Console.WriteLine("All data chunks processed.");
}

public static async Task Main(string[] args)
{
    Program program = new Program();
    await program.ProcessLargeDatasetAsync(5); // Process 5 chunks
}
```

### Explanation

- **ProcessDataChunkAsync Method:** This method simulates processing a single chunk of data. You don't need to modify this method.
- **ProcessLargeDatasetAsync Method:** You need to complete this method to start processing multiple chunks concurrently. Use a loop to create a task for each chunk, add it to a list, and use `Task.WhenAll` to ensure all tasks finish before displaying a completion message.
- **Running the Code:** When you run the `Main` method, it should show messages for each chunk being processed and completed, followed by a message saying all data chunks have been processed.

**Code File:** See [Solution2_ProcessData.cs](Solutions/Solution2_ProcessData.cs)
