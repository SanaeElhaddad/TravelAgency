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
    public class GuideRepository : IRepositoryGenerique<Guide>
    {
        private DbSet<Guide> table = null;
        private TravelEntities db;
        public GuideRepository()
        {
            this.db = new TravelEntities();
            table = db.Set<Guide>();
        }
        public GuideRepository(TravelEntities db)
        {
            this.db = new TravelEntities();
            table = db.Set<Guide>();
        }
        public void Delete(object id)
        {
            Guide found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Guide> GetAll()
        {
            return table.ToList();
        }

        public Guide GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(Guide entity)
        {
            table.Add(entity);
        }

        public void Update(Guide entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
