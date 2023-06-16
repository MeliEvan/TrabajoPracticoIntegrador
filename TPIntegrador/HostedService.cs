//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.Extensions.Hosting;
using System;

internal class HostedService : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Work in progress");
        //throw new NotImplementedException();
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Work stopped");
        //throw new NotImplementedException();
    }
}