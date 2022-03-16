using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyApp.Models;
using MyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Shared
{
    public partial class TopNav
    {
        [Inject] public IJSRuntime JS { get; set; }
        [Inject] IRemoteDataService DataService { get; set; }
        [Inject] UserService UService { get; set; }
        public IEnumerable<Link> Links { get; set; } 
        bool loggedIn;

        void Back()
        {
            JS.InvokeVoidAsync("window.history.back");
        }

        bool togglenav = false;
        void Switchbtn()
        {
            togglenav = !togglenav;
        }

 
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                loggedIn = await UService.IsLoggedIn();
                //Links = await DataService.GetNav(loggedIn);
                StateHasChanged();
            }
                await base.OnAfterRenderAsync(firstRender);
        }
    }
}
