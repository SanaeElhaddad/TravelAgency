using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyApp.DOA;
using TravelAgencyApp.Model;

namespace TravelAgencyApp.Repository
{
    public class ClientRepository : IRepositoryGenerique<Client>
    {
        private DbSet<Client> table = null;
        private TravelEntities db;
        public ClientRepository()
        {
            this.db = new TravelEntities();
            table = db.Set<Client>();
        }
        public ClientRepository(TravelEntities db)
        {
            this.db = new TravelEntities();
            table = db.Set<Client>();
        }
        public void Delete(object id)
        {
            Client found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Client> GetAll()
        {
            return table.ToList();
        }

        public Client GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(Client entity)
        {
            table.Add(entity);
        }

        public void Update(Client entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
