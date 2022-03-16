using Microsoft.AspNetCore.Components;
using MyApp.Models;
using MyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Pages
{

    public partial class Index
    {
        [Inject] public IRemoteDataService DataService { get; set; }

        string Heading => "OUR DATA PLANS";
        NetworkType[] Networks = new NetworkType[0];
        Dictionary<NetworkType, DataAmount[]> Plans = new Dictionary<NetworkType, DataAmount[]>();

        //DataAmount[] PlanAndAmount = new DataAmount[0];
        string[] WiseWords = new string[]
        {
            "Surf The Web With Smiles",
            "Affordable, Easy & Fast",
            "Top-Up With One-Click"
        };
        int wiseWordIndex = 0;
        bool showWise = false;
        //navBar = document.getElementsByClassName("nav-bar");
        Link[] links = new Link[] {
           new Link { Label = "home", Address="" },
            new Link {Label="login", Address="login"},
            new Link { Label= "register", Address="register"}
        };


        protected override void OnInitialized()
        {
            Task.Run(async () =>
            {
                Random random = new Random();
                while (true)
                {
                    showWise = false;
                    _ = InvokeAsync(StateHasChanged);
                    await Task.Delay(2000);
                    wiseWordIndex = random.Next(WiseWords.Length);
                    showWise = true;
                    _ = InvokeAsync(StateHasChanged);
                    await Task.Delay(5000);
                }


            });


            base.OnInitialized();
        }
        string GetWiseWord()
        {
            return WiseWords[wiseWordIndex];
        }


        protected override async Task OnInitializedAsync()
        {
            Networks = await DataService.GetNetworks();
            //PlanAndAmount = await DataService.GetDataAmounts(Networks );
            foreach(var net in Networks)
            {
                var plan = await DataService.GetDataAmounts(net);
                Plans[net] = plan;
            }
            await base.OnInitializedAsync();
        }        
    }  
}

