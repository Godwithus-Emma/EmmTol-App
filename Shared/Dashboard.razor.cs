using Microsoft.AspNetCore.Components;
using MyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Shared
{
    public partial class Dashboard
    {
        [Inject] public UserService Uservice { get; set; }
        [Inject] IRemoteDataService DataService { get; set; }
        string Title => "Dashboard";
        string Balance { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        bool loading;
        //string[] Header => [""];
        bool hide => false;
        bool toggle= false;

        void ToggleBar()
        {
            toggle = !toggle;
        }
        protected override void OnInitialized()
        {
            Balance = DataService.GetBalance();
            base.OnInitialized();
        }
    }
}
