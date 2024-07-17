﻿// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using WeAreDevelopers.Models.Foundations.Navigations.Exceptions;

namespace WeAreDevelopers.Services.Foundations.Navigations
{
    public partial class NavigationService
    {
        private delegate void ProcessNavigation();

        private void TryCatch(ProcessNavigation processNavigation)
        {
            try
            {
                processNavigation();
            }
            catch (InvalidNavigationUrlException invalidNavigationUrlException)
            {
                throw CreateAndLogValidationException(invalidNavigationUrlException);
            }
        }

        private NavigationValidationException CreateAndLogValidationException(
            InvalidNavigationUrlException invalidNavigationUrlException)
        {
            var navigationValidationException =
                new NavigationValidationException(invalidNavigationUrlException);

            this.loggingBroker.LogError(navigationValidationException);

            return navigationValidationException;
        }
    }
}
