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
    public class ReservationRepository : IRepositoryGenerique<Reservation>
    {
        private DbSet<Reservation> table = null;
        private TravelEntities db;
        public ReservationRepository()
        {
            this.db = new TravelEntities();
            table = db.Set<Reservation>();
        }
        public ReservationRepository(TravelEntities db)
        {
            this.db = new TravelEntities();
            table = db.Set<Reservation>();
        }
        public void Delete(object id)
        {
            Reservation found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Reservation> GetAll()
        {
            return table.ToList();
        }

        public Reservation GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(Reservation entity)
        {
            table.Add(entity);
        }

        public void Update(Reservation entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
