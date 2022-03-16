using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Services
{

    public interface IRemoteDataService
    {
        Task<NetworkType[]> GetNetworks();
        Task<DataAmount[]> GetDataAmounts(NetworkType networkName);
        Task<AuthenticationTicket> Login(string email, string password);
        Task Logout();
        Task<Registration> Register(string email, string pass);
        Task<RecoverPassword> Recover(string email);
        Task<object> BuyData(string ticket, NetworkType network, string plan, string phoneNum);
        string GetBalance();
        //Task<IEnumerable<Link>> GetNav(bool loggedIn);
        // abstract buyAirtime()
    };
}
