// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System;

namespace WeAreDevelopers.Models.Foundations.Navigations.Exceptions
{
    public class NavigationValidationException(Exception innerException) : Exception(
        message: "Navigation validation error occurred, contact support.", innerException)
    { }
}
