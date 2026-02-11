// Basic async/await - Download simulation
using System;
using System.Threading.Tasks;

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
