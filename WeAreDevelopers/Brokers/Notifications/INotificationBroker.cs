// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for WeAreDevelopers World Congress 2024.
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;

namespace WeAreDevelopers.Brokers.Notifications
{
    public interface INotificationBroker
    {
        Action<string> OnMessageReceived { get; set; }
        Task StartAsync();
        Task StopAsync();
    }
}
