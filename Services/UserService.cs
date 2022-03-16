using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public partial class UserService
    {
        public IRemoteDataService DataService { get; set; }
        IJSRuntime js;
        private string ticket;
        public UserService(IRemoteDataService Service, IJSRuntime _js)
        {
            DataService = Service;
            js = _js;
        }
        
        public int ToNumber(string data)
        {
            int value = int.Parse(data);
            return value;
        }

        string ValidateEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                return "Please Enter your Email";
            }
            Regex ff = new Regex(@"^\w+@\w+\.\w+");
            if (ff.IsMatch(email))
                return "";
            return "Invalid Email Address";
            
        }
        string ValidatePassword(string pass)
        {
            if (String.IsNullOrEmpty(pass))
            {
                return "Please Enter your Password";
            }
            if (6 > pass.Length)
                return "Password must be at least 6 characters";
            return "";
        }
        string FormatNumber(string number)
        {

            Regex ff = new Regex(@"^[0]\d{10}$");
            if (ff.IsMatch(number))
                return "Invalid Phone Number";
            return "";
        }

        public async Task<bool> IsLoggedIn()
        {
            var Item = await js.InvokeAsync<string>("localStorage.getItem", "Ticket");
            if (String.IsNullOrEmpty(Item))
                return false;
            ticket = Item;
            return true;
        }
        public string GetTicket()
        {
            return ticket;
        }
        private async void SaveTicket(string ticketName, string ticket)
        {
            await js.InvokeVoidAsync("localStorage.setItem", ticketName, ticket);
        }

        public async Task<AuthenticationTicket> Login(string email, string password)
        {
            string ve = ValidateEmail(email);
            if (!(String.IsNullOrEmpty(ve)))
            {
                return new AuthenticationTicket { Success=false, Error=ve, Ticket=null };
            }
            string vp = ValidatePassword(password);
            if (!(String.IsNullOrEmpty(vp)))
            {
                return new AuthenticationTicket { Success = false, Error = vp, Ticket = null };
            }
            var w = await DataService.Login(email, password);
            if (w.Ticket!=null)
            {
                SaveTicket("Ticket", w.Ticket);
            }
            return w;
        }
        public async Task Logout()
        {
            await DataService.Logout();

        }

        public async Task<AuthenticationTicket> Register(string email, string password)
        {
            string ve = ValidateEmail(email);
            if (!(String.IsNullOrEmpty(ve)))
            {
                return new AuthenticationTicket { Success = false, Error = ve, Ticket = null };
            }
            string vp = ValidatePassword(password);
            if (!(String.IsNullOrEmpty(vp)))
            {
                return new AuthenticationTicket { Success = false, Error = vp, Ticket = null };
            }
            var w = await DataService.Login(email, password);
            return w;
        }
        public async Task<RecoverPassword> Recover(string email)
        {
            string ve = ValidateEmail(email);
            if (!(String.IsNullOrEmpty(ve)))
            {
                return new RecoverPassword { Success = false, Notice = "Email does not exist"};
            }

            var w = await DataService.Recover(email);
            return w;

        }

    }


}

