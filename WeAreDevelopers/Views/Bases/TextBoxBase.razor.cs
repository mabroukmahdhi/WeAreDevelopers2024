// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for WeAreDevelopers World Congress 2024.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace WeAreDevelopers.Views.Bases
{
    public partial class TextBoxBase : ComponentBase
    {
        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public EventCallback<string> TextChanged { get; set; }

        [Parameter]
        public string Label { get; set; }

        private void OnValueChanged(string newValue)
        {
            Text = newValue;
            TextChanged.InvokeAsync(newValue);
        }   
    }
}
