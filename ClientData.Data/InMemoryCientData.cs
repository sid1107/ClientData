using ClientRepo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientData.Data
{
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

        public Repository Add(Repository newClientData)
        {
            repo.Add(newClientData);
            newClientData.Clientid = repo.Max(r => r.Clientid) + 1;
            return newClientData;
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Repository> getClientByName(string Name = null)
        {
            
            
                return from rec in repo
                  where string.IsNullOrEmpty(Name)|| rec.ClientName.ToLower().StartsWith(Name.ToLower())
                   orderby rec.Clientid
                    select rec;
        }
    }
}
