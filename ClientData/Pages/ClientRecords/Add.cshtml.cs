using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientData.Data;
using ClientRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClientData.Pages
{
    public class AddModel : PageModel
    {
        private readonly IClientRecord clientData;
        [BindProperty]
        public Repository ClientRepo { get; set; }
        [TempData]
        public string Message { get; set; }

        public string DispMessage { get; set; }
        public AddModel(IClientRecord clientData)
        {
            this.clientData = clientData;
        }
        public void OnGet()
        {
            DispMessage = "";
            //ClientRepo = new Repository();
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                clientData.Add(ClientRepo);
                DispMessage = "Client Record is Created"; ;
            }


            TempData["Message"] = "Client Record is Created";

            // clientData.Commit();
        }
    }
}
