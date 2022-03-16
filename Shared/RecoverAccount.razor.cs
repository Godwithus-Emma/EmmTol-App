using Microsoft.AspNetCore.Components;
using MyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Shared
{
    public partial class RecoverAccount
    {
        [Inject] public UserService UService { get; set; }
        Notice _notice;
        public string Title = "Recover Password";
        public string Email { get; set; }
        public string Notification { get; set; }


        async Task Recover()
        {
            var error = await UService.Recover(Email);
            if (error.Notice != null)
                await _notice.Show(error.Notice, false);
            else
                await _notice.Show("Recovery email has been sent to inbox", true);
        }

    }
}
