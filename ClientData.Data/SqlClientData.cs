using ClientRepo;
using System.Collections.Generic;
using System.Linq;
namespace ClientData.Data
{
    public class SqlClientData : IClientRecord
    {
        private readonly ClientDbContext dbContext;

        public SqlClientData(ClientDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Repository Add(Repository newClientData)
        {
            dbContext.Add(newClientData);
            return newClientData;
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }

        public Repository getClientById(int id)
        {
            return dbContext.ClientData.FirstOrDefault(e => e.Clientid == id);
        }

        public IEnumerable<Repository> getClientByName(string Name)
        {
            var query = from r in dbContext.ClientData
                        where string.IsNullOrEmpty(Name) || r.ClientName.ToLower().StartsWith(Name.ToLower())
                        orderby r.Clientid
                        select r;
            return query;
        }
    }
}
