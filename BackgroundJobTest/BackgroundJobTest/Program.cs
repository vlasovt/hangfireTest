using System;
using BackgroundJobTest.Core;
using Hangfire;

namespace BackgroundJobTest
{
    class Program
    {
        static void Main()
        {
            GlobalConfiguration.Configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseColouredConsoleLogProvider()
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage(@"Server=(LocalDb)\MSSQLLocalDB;Database=hangfireBox; Integrated Security=True;");

            //BackgroundJob.Enqueue(() => Console.WriteLine("Hello, world!"));

            //for(int i = 0; i < 50; i++)
            //{
            //    BackgroundJob.Schedule(() => Console.WriteLine("Hello, world " + i), TimeSpan.FromSeconds(i + 1));
            //}

            BackgroundJob.Enqueue<IOffenderManager>(ms => ms.CreateNewOffender());

            //RecurringJob.AddOrUpdate(() => Console.WriteLine("Daily job"), Cron.Daily(18, 55));

            // pro only
            //BatchJob.StartNew(x =>
            //{
            //    for (var i = 0; i < 10; i++)
            //    {
            //        x.Enqueue(() => SendEmail(i));
            //    }
            //});

            // can be also started in console, webforms, mvc, web api, asp.net app,  Microsoft Azure Worker Role, push with SignalR, etc
        }
    }
}
