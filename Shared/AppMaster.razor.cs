using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Shared
{
    public partial class AppMaster
    {
        IEnumerable<Link> Links = new Link[]
        {
            new Link
            {
                Label = " Buy Airtime",
                Address = " AirtimeTopup"
            },
            new Link
            {
                Label = " Buy Data",
                Address = "DataTopup"
            },
            new Link
            {
                Label = " Fund Wallet",
                Address = "FundWallet"
            }
        };
    }
}
