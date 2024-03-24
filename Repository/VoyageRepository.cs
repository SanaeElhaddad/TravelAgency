using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyApp.DOA;
using TravelAgencyApp.Model;

namespace TravelAgencyApp.Repository
{
    public class VoyageRepository : IRepositoryGenerique<Voyage>
    {
        private DbSet<Voyage> table = null;
        private TravelEntities db;
        public VoyageRepository()
        {
            this.db = new TravelEntities();
            table = db.Set<Voyage>();
        }
        public VoyageRepository(TravelEntities db)
        {
            this.db = new TravelEntities();
            table = db.Set<Voyage>();
        }
        public void Delete(object id)
        {
            Voyage found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Voyage> GetAll()
        {
            return table.ToList();
        }

        public Voyage GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(Voyage entity)
        {
            table.Add(entity);
        }

        public void Update(Voyage entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
       

    }
}
