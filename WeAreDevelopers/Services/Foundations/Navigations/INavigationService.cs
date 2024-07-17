﻿// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

namespace WeAreDevelopers.Services.Foundations.Navigations
{
    public interface INavigationService
    {
        void NavigateTo(string uri);
        void OpenNewTab(string uri);
    }
}
