using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClientRepo
{
    public class Repository
    {
        [Key]
        public int Clientid { get; set; }
        public string   CleintAddress { get; set;}
        public string ClientName { get; set; }

        public string location { get; set; }
        public string totemp { get; set; }
    }
}
