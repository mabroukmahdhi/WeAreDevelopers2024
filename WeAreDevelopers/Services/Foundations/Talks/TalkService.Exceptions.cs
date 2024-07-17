// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeAreDevelopers.Models.Foundations.Talks;
using WeAreDevelopers.Models.Foundations.Talks.Exceptions;

namespace WeAreDevelopers.Services.Foundations.Talks
{
    public partial class TalkService
    {
        private delegate ValueTask<List<Talk>> ReturningTalksFunction();

        private async ValueTask<List<Talk>> TryCatch(ReturningTalksFunction returningTalksFunction)
        {
            try
            {
                return await returningTalksFunction();
            }
            catch (Exception exception)
            {
                var failedTalkServiceException =
                    new FailedTalkServiceException(exception);

                throw CreateAndLogTalkServiceException(failedTalkServiceException);
            }
        }

        private TalkServiceException CreateAndLogTalkServiceException(Exception exception)
        {
            var TalkServiceException =
                new TalkServiceException(exception);

            this.loggingBroker.LogError(TalkServiceException);

            return TalkServiceException;
        }
    }
}