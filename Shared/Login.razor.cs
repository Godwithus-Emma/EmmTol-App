using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Shared
{
    public partial class Login
    {
        [Inject] public UserService UService { get; set; }
        [Inject] public NavigationManager Navigation { get; set; }
        [Inject] public IJSRuntime JS { get; set; }
        [Parameter] public EventCallback OnLoggedIn { get; set; }
        [Parameter] public string Url { get; set; }
        Notice _notice;
        bool loading = false;
        //string Notification;
        string Email { get; set; }
        string Password { get; set; }
        bool FadeIn=false;
        bool Success = false;

        async Task UserLogin()
        {

            FadeIn = true;
            var error = await UService.Login(Email, Password);
            if (error.Error != null)
            {
                await _notice.Show(error.Error, false);
                //this.Notification = error.Error;
                //Console.WriteLine(this.Notification);

                //await JS.InvokeVoidAsync("console.log", this.Notification);
                //await Task.Delay(5000);
                //FadeIn = false;
                //this.Notification = null;
                //await InvokeAsync(StateHasChanged);
            }
            else
            {
                Success = true;
                await OnLoggedIn.InvokeAsync(this);
                //await _notice.Show("Login Successful", true);
                
                loading = true;
                StateHasChanged();
                await Task.Delay(2000);
                if (Url == null)
                    Navigation.NavigateTo("/Dashboard");
                else
                {
                    Navigation.NavigateTo(Url);
                }

                //await JS.InvokeVoidAsync("window.location.href", "/Dashboard");
                // this.Notification = "Login Successful";
            }
        }
    }
}
