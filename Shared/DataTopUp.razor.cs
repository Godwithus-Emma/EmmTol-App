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
    public partial class DataTopUp
    {
        [Inject] IRemoteDataService DataService { get; set; }
        [Inject]UserService UService { get; set; }
        [Inject] IJSRuntime _js { get; set; }
        NetworkType[] Networks = new NetworkType[0];
        Dictionary<NetworkType, DataAmount[]> Plans = new Dictionary<NetworkType, DataAmount[]>();
        Notice _notice { get; set; }
        NetworkType SelectedNetwork { get; set; }
        string SelectedAmount { get; set; }
        string PhoneNumber { get; set; }
        bool processing= false;


         async Task Submit()
        {

            if (!(String.IsNullOrEmpty(PhoneNumber) || PhoneNumber.Length < 11))
            {
                
                processing = true;
                var res = await DataService.BuyData(UService.GetTicket(), SelectedNetwork, SelectedAmount, PhoneNumber);
                processing = false;
            }

            else
            {
                await _notice.Show("Please Enter a Valid Phone Number", false);
            }
        }




        protected override async Task OnInitializedAsync()
        {
            
            Networks = await DataService.GetNetworks();
            foreach(var net in Networks)
            {
                var plan = await DataService.GetDataAmounts(net);
                Plans[net] = plan;
            }
            await  base.OnInitializedAsync();
        }


    }
}
