using Microsoft.AspNetCore.Components;
using MyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Shared
{
    public partial class Authentication
    {
        [Inject] public UserService Uservice { get; set; }
        [Parameter ] public RenderFragment ChildContent { get; set; }
        [Parameter] public string Url { get; set; }
        bool loggedIn;
        bool _checked;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                loggedIn = await Uservice.IsLoggedIn();
                _checked=true;
                StateHasChanged();
            }
            await  base.OnAfterRenderAsync(firstRender);
        }

        Task LoggedIn()
        {
            loggedIn=true;
            _checked = true;
            return InvokeAsync(StateHasChanged);
        }
    }

}
