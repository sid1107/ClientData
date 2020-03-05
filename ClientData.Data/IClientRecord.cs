using ClientRepo;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Data
{
    public interface IClientRecord
    {
        IEnumerable<Repository> getClientByName(string Name);
        Repository Add(Repository newClientData);
        int Commit();
    }
}
