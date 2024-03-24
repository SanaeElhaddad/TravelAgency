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
    public class PersonnelRepository : IRepositoryGenerique<Personnel>

    {
        private DbSet<Personnel> table = null;
        private TravelEntities db;

       
        public PersonnelRepository(TravelEntities db)
        {
            this.db = new TravelEntities();
            table = db.Set<Personnel>();
        }
        public PersonnelRepository()
        {
            this.db = new TravelEntities();
            table = db.Set<Personnel>();
        }

        public void Delete(object id)
        {
            Personnel found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Personnel> GetAll()
        {
            return table.ToList();
        }

        public Personnel GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(Personnel entity)
        {
            table.Add(entity);
        }

        public void Update(Personnel entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
