using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();

            var settings = new CustomAppSetting();
            configuration.Bind(settings);

            var value1 = settings.ApplicationName;
            Console.WriteLine(value1);
            Console.WriteLine($"My application name is '{settings.ApplicationName}'");

            Console.ReadLine();

        }
    }
}