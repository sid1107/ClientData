using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClientData
{
    public class DetailModel : PageModel
    {
        public Repository ClientRepo { get; set; }
        public void OnGet(int ClientId)
        {
            ClientRepo = new Repository();
            ClientRepo.Clientid = ClientId;
        }
    }
}