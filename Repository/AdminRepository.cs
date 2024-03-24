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
    internal class AdminRepository : IRepositoryGenerique<Admin>
    {
        private DbSet<Admin> table = null;
        private TravelEntities db;

        public AdminRepository()
        {
            this.db = new TravelEntities();
            table = db.Set<Admin>();
        }
        public AdminRepository(TravelEntities db)
        {
            this.db = new TravelEntities();
            table = db.Set<Admin>();
        }
        public void Delete(object id)
        {
            Admin found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Admin> GetAll()
        {
            return table.ToList();
        }

        public Admin GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(Admin entity)
        {
            table.Add(entity);
        }

        public void Update(Admin entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
