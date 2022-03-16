using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Shared
{
    public partial class Registration
    {
        [Inject] public UserService UService { get; set; }
       // [Inject] public IJSRuntime JS { get; set; }
        Notice _notice;
        Login _login;
        //string Notification;
        //bool Success = false;
        string Email { get; set; }
        string InitialPassword { get; set; }
        string Password { get; set; }
        //bool FadeIn = false;

        //async public void Message(string message)
        //{
        //    FadeIn = true;
        //    Notification = message;
        //    Console.WriteLine(this.Notification);
        //    await JS.InvokeVoidAsync("console.log", Notification);
        //    await Task.Delay(5000);
        //    FadeIn = false;
        //    Notification = null;
        //    await InvokeAsync(StateHasChanged);
        //}
        async Task NewUser()
            {
                if(Password!= InitialPassword)
            {
                await _notice.Show("Password do not match", false);
                return;
            }
            var error = await UService.Register(Email, Password);
            if (error.Error != null)
            {
                await _notice.Show(error.Error, false);    
            }
            else
            {
                await _notice.Show("Registration Successful", true);
            }
        }
    }
}

