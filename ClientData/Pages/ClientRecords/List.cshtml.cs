using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientData.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using ClientRepo;

namespace ClientData.Pages.ClientRecords
{
    public class ListModel : PageModel
    {
        private readonly IClientRecord clientRec;
        public IEnumerable<Repository> ClientRepo { get; set; }

        public ListModel(IClientRecord ClientRec)
        {
            this.clientRec = ClientRec;
        }
        public void OnGet()
        {
            ClientRepo = clientRec.getALL();
        }
    }
}
