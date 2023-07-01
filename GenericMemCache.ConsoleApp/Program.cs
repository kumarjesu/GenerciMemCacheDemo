// See https://aka.ms/new-console-template for more information

using GenericMemCache.ConsoleApp;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = ContainerConfiguration.Configure();

Console.WriteLine("Set Cache !!!!");
var repo = serviceProvider.GetService<IMemCacheRepository>();
repo.SaveMemCache("KEY", "Initial Cache !!!!");

var provider = serviceProvider.GetService<IMemCacheProvider>();
Console.WriteLine($"Cache Value for Key is {provider.GetCacheProvier<string>("KEY")}");

Thread.Sleep(1000 * 60);

Console.WriteLine($"Cache Value for Key is {provider.GetCacheProvier<string>("KEY")}");

Console.ReadLine();
