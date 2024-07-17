// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for WeAreDevelopers World Congress 2024.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Configuration;
using WeAreDevelopers.Models.Configurations;

namespace WeAreDevelopers.Brokers.Notifications
{
    public class NotificationBroker : INotificationBroker
    {
        private readonly HubConnection hubConnection;

        public NotificationBroker(IConfiguration configuration)
        {
            var hubUrl = configuration.Get<LocalConfiguration>()
                .ApiConfiguration
                .HubUrl;

            hubConnection = new HubConnectionBuilder()
                .WithUrl(hubUrl)
                .Build();
        }

        public Action<string> OnMessageReceived { get; set; }

        public async Task StartAsync()
        {
            hubConnection.On<string>("ReceiveMessage", (message) =>
            {
                OnMessageReceived?.Invoke(message);
            });

            await hubConnection.StartAsync();
        }

        public async Task StopAsync() =>
            await hubConnection.StopAsync();
    }
}
