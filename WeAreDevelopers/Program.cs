// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;
using WeAreDevelopers.Applications;
using WeAreDevelopers.Brokers.Apis;
using WeAreDevelopers.Brokers.DateTimes;
using WeAreDevelopers.Brokers.Loggings;
using WeAreDevelopers.Brokers.Navigations;
using WeAreDevelopers.Brokers.Notifications;
using WeAreDevelopers.Services.Foundations.Navigations;
using WeAreDevelopers.Services.Foundations.Talks;
using WeAreDevelopers.Services.Views.TalkViews;

namespace WeAreDevelopers
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<MainApplication>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient();

            builder.Services.AddFluentUIComponents();

            builder.Services.AddSingleton<IDateTimeBroker, DateTimeBroker>();
            builder.Services.AddSingleton<ILoggingBroker, LoggingBroker>();
            builder.Services.AddScoped<IApiBroker, ApiBroker>();
            builder.Services.AddScoped<INavigationBroker, NavigationBroker>();
            builder.Services.AddScoped<INotificationBroker, NotificationBroker>();

            builder.Services.AddScoped<ITalkService, TalkService>();
            builder.Services.AddScoped<INavigationService, NavigationService>();

            builder.Services.AddScoped<ITalkViewService, TalkViewService>();

            await builder.Build().RunAsync();
        }
    }
}