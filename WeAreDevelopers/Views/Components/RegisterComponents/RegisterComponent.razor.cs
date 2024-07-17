// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for WeAreDevelopers World Congress 2024.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace WeAreDevelopers.Views.Components.RegisterComponents
{
    public partial class RegisterComponent : ComponentBase
    {
        private string attendeeName { get; set; }

        override protected void OnInitialized()
        {
            attendeeName = "Change me";
        }
    }
}
