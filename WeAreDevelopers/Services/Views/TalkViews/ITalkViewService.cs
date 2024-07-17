﻿// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using WeAreDevelopers.Models.Views.TalkViews;

namespace WeAreDevelopers.Services.Views.TalkViews
{
    public interface ITalkViewService
    {
        ValueTask<List<TalkView>> RetrieveAllTalkViewsAsync();
        void NavigateToYoutube(string url);
    }
}
