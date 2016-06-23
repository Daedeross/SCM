using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using SCMMVC.Models;
using Microsoft.AspNet.Identity;
using System.Data.Entity;

namespace SCMMVC.Hubs
{
    [Authorize]
    public class EncounterHub : Hub<IClient>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public override Task OnConnected()
        {
            var name = Context.User.Identity.Name;
            Clients.All.SendMessage("Welcome " + Context.User.Identity.Name + "!");

            return base.OnConnected();
        }

        public void Echo(string value)
        {
            Clients.Caller.SendMessage(value);
        }

        public void CreateEncounter()
        {
            
        }
    }
}