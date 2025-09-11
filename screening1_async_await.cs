// Question: What will this code output and why?
// What potential issue exists in this code?

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start");
        var task = DoWorkAsync();
        Console.WriteLine("Middle");
        await task;
        Console.WriteLine("End");
    }
    
    static async Task DoWorkAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("Work Complete");
    }
}