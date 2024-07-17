// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using WeAreDevelopers.Models.Foundations.Talks;

namespace WeAreDevelopers.Services.Foundations.Talks
{
    public interface ITalkService
    {
        ValueTask<List<Talk>> RetrieveAllTalksAsync();
    }
}