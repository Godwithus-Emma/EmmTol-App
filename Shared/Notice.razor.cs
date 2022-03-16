using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Shared
{
    public partial class Notice
    {
        [Inject] public IJSRuntime JS { get; set; }
        string Notification { get; set; }
        bool FadeIn { get; set; }
        bool Success { get; set; }

        string _notification;
        async public Task Show(string message, bool success)
        {

            FadeIn = true;
            _notification = message;
            Success = success;
            Console.WriteLine(message);
            await JS.InvokeVoidAsync("console.log", message);
            await InvokeAsync(StateHasChanged);
            await Task.Delay(5000);
            FadeIn = false;
            await InvokeAsync(StateHasChanged);
            await Task.Delay(1000);
            _notification = null;
            await InvokeAsync(StateHasChanged);
        }
    }
}
