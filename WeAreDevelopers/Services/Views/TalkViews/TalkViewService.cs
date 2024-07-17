// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeAreDevelopers.Models.Foundations.Talks;
using WeAreDevelopers.Models.Views.TalkViews;
using WeAreDevelopers.Services.Foundations.Navigations;
using WeAreDevelopers.Services.Foundations.Talks;

namespace WeAreDevelopers.Services.Views.TalkViews
{
    public class TalkViewService(ITalkService talkService, INavigationService navigationService) 
        : ITalkViewService
    {
        private readonly ITalkService talkService = talkService;
        private readonly INavigationService navigationService = navigationService;

        public void NavigateToYoutube(string url) =>
            this.navigationService.NavigateTo(url);

        public async ValueTask<List<TalkView>> RetrieveAllTalkViewsAsync()
        {
            var talks = await this.talkService.RetrieveAllTalksAsync();

            return talks?.Select(AsTalkView)?.ToList();
        }

        private static TalkView AsTalkView(Talk talk)
        {
            return new TalkView
            {
                Title = talk.HasDisplayTitle ? talk.DisplayTitle : talk.Title?.Replace("On .NET Live: ", ""),
                Description = talk.Description,
                GuestName = talk.Guests[0].Name.Split(Environment.NewLine)[0],
                GuestSocial = talk.Guests[0].Social,
                GuestThumbnailUrl = talk.ThumbnailUrl,
                YouTubeUrl = talk.Url,
                Tags = talk.Tags
            };
        }
    }
}
