using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public class FakeRemoteDataService: IRemoteDataService
    {
        
        IJSRuntime js;
        NavigationManager Navigation;
        double Balance= 200.50;
        public FakeRemoteDataService(IJSRuntime _js, NavigationManager _Navigation)
        {
            js = _js;
            Navigation = _Navigation;
        }
        public async Task<object> BuyData(string ticket, NetworkType network, string plan, string phoneNum)
        {
            await Task.Delay(3000);
            return new object();
        }

        public Task<DataAmount[]> GetDataAmounts(NetworkType networkName)
        {

            if (networkName == NetworkType.MTN)
            {
                return Task.FromResult(new DataAmount[] {
                    new DataAmount { DataVolume= "1GB", Amount=400 },
                    new DataAmount { DataVolume= "2GB", Amount=800 },
                    new DataAmount {DataVolume= "4GB", Amount=1600 },
                   new DataAmount { DataVolume= "8GB", Amount=3200 }
                    });
            }
            else if (networkName == NetworkType.Glo)
            {
               return Task.FromResult(new DataAmount[] {
        new DataAmount{ DataVolume= "250MB[1 Night Plan]", Amount=50 },
        new DataAmount{ DataVolume= "32MB[Daily Mini Plan", Amount=70 },
        new DataAmount{ DataVolume= "500MB[1 Night Plan]", Amount=80 },
        new DataAmount{ DataVolume= "1GB [5 Nights Plan]", Amount=150 },
        new DataAmount{ DataVolume= "1.05GB[2 Weeks Plan]", Amount=550 },
        new DataAmount{ DataVolume= "2.9GB[1 Month Plan", Amount=1200 },
        new DataAmount{ DataVolume= "10MB[1 Month Plan]", Amount=3000 }
      });

            }
            else if (networkName == NetworkType.Etisalat)
            {
                return Task.FromResult(new DataAmount[]
                {
        new DataAmount{ DataVolume= "500MB[1 Month Plan]", Amount=550 },
        new DataAmount{ DataVolume= "2GB[1 Month Plan", Amount=1200 },
        new DataAmount{ DataVolume= "3GB[1 Month Plan]", Amount=1500 },
        new DataAmount{ DataVolume= "4.5GB [1 Month Plan]", Amount=2000 },
        new DataAmount{ DataVolume= "11GB[1 Month Plan]", Amount=4200 }
                });
            }
            else if (networkName == NetworkType.Airtel)
            {
                return Task.FromResult(new DataAmount[] {
       new DataAmount { DataVolume= "750MB[2 Weeks Plan]", Amount=550 },
        new DataAmount{ DataVolume= "2GB[1 Month Plan", Amount=1200 },
        new DataAmount{ DataVolume= "4.5GB[1 Month Plan]", Amount=2100 },
        new DataAmount{ DataVolume= "10GB Month Plan]", Amount=3000 }
      });
            }
            return Task.FromResult(new DataAmount[]
            {
            });
        }
        public Task<NetworkType[]> GetNetworks()
        {
             return Task.FromResult( new NetworkType[] {
                NetworkType.MTN, NetworkType.Glo, NetworkType.Etisalat, NetworkType.Airtel
            });
        }

        public Task<AuthenticationTicket> Login(string email, string password)
        {
            bool success = email.EndsWith(".com") && password.EndsWith(".");
            return Task.FromResult(new AuthenticationTicket
            {
                Success = success,
                Ticket = success ? "dummyTicket" : null,
                Error = success? null : "Invalid Username/password"
            });
        }
        public async Task Logout()
        {
            await js.InvokeVoidAsync("localStorage.removeItem", "Ticket");
            Navigation.NavigateTo("/");
            
        }

        //public Task<RecoverPassword> RecoverPassword(string email)
        //{
        //    return Task.FromResult(new Models.RecoverPassword
        //    {
        //        Success = email.EndsWith(".com")
        //    });
        //}

        public Task<Registration> Register(string email, string pass)
        {
            bool success = email.EndsWith(".com");
            return Task.FromResult(new Registration
            {
                Success = success,
                Ticket = success ? "Registration Success " : "Invalid email/password"
            });
        }
        public Task<RecoverPassword> Recover(string email)
        {
            bool success = email.EndsWith(".com");
            return Task.FromResult(new RecoverPassword
            {
                Success = success,
                Notice = success ? "Recovery email has been sent!" : "Email does not exist"
            });
        }
        public string GetBalance()
        {
            string _Balance = Balance.ToString();
            return _Balance;
        }
        //public Task<IEnumerable<Link>> GetNav(bool isLoggedIn)
        //{
        //    if (isLoggedIn == true)
        //    {
        //        return Task.FromResult(new Link[]
        //        {
        //            new Link
        //            {
        //                Label = "Home",
        //                Adr
        //            },
        //            new Link
        //            {

        //            }
        //            Title=new List<string>() { "Home", "Dashboard", "LogOut" },
        //            Address = new List<string>() { "", "Dashboard", "Logout"}
                    
                    
        //        });;
        //    }
        //    else
        //    {
        //        return Task.FromResult(new MyNavigation
        //        {
        //            Title = new List<string>() { "Home", "Login", "Register" },
        //            Address = new List<string>() { "", "Login", "Register" }
        //        });
        //    } 
        //}
    }
}
