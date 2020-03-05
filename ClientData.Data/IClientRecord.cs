using ClientRepo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClientData.Data
{
    public interface IClientRecord
    {
        IEnumerable<Repository> getALL();
    }

    public class InMemoryCientData : IClientRecord
    {
        readonly List<Repository> repo;
        public InMemoryCientData()
        {
            repo = new List<Repository>()
            {
                new Repository { Clientid =1,ClientName="Google",location="India",totemp="50"},
                new Repository { Clientid =2,ClientName="Adidas",location="USA",totemp="250"},
                new Repository { Clientid =3,ClientName="Reebok",location="Germany",totemp="1050"},
                new Repository { Clientid =4,ClientName="Merc",location="Japan",totemp="9000"}
            };
        }
        public IEnumerable<Repository> getALL()
        {
                return from rec in repo
                   orderby rec.Clientid
                    select rec;
        }
    }
}
