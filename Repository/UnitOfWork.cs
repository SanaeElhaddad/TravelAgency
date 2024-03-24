using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyApp.DOA;
using TravelAgencyApp.Model;

namespace TravelAgencyApp.Repository
{
    internal class UnitOfWork : IDisposable
    {
        private readonly TravelEntities dbContext;
        public UnitOfWork()
        {
            dbContext = new TravelEntities();
        }
        private IRepositoryGenerique<Personnel> personnelRepository;
        public IRepositoryGenerique<Personnel> PersonnelRepository
        {
            get
            {
                if (personnelRepository == null)
                {
                    personnelRepository = new PersonnelRepository(dbContext);
                }
                return personnelRepository;
            }
        }
        private IRepositoryGenerique<Admin> adminRepository;
        public IRepositoryGenerique<Admin> AdminRepository
        {
            get
            {
                if (adminRepository == null)
                {
                    adminRepository = new AdminRepository(dbContext);
                }
                return adminRepository;
            }
        }

        private IRepositoryGenerique<Client> clientRepository;
        public IRepositoryGenerique<Client> ClientRepository
        {
            get
            {
                if (clientRepository == null)
                {
                    clientRepository = new ClientRepository(dbContext);
                }
                return clientRepository;
            }
        }

        private IRepositoryGenerique<Guide> guideRepository;
        public IRepositoryGenerique<Guide> GuideRepository
        {
            get
            {
                if (guideRepository == null)
                {
                    guideRepository = new GuideRepository(dbContext);
                }
                return guideRepository;
            }
        }

        private IRepositoryGenerique<Voyage> voyageRepository;
        public IRepositoryGenerique<Voyage> VoyageRepository
        {
            get
            {
                if (voyageRepository == null)
                {
                    voyageRepository = new VoyageRepository(dbContext);
                }
                return voyageRepository;
            }
        }

        private IRepositoryGenerique<Reservation> reservationRepository;
        public IRepositoryGenerique<Reservation> ReservationRepository
        {
            get
            {
                if (reservationRepository == null)
                {
                    reservationRepository = new ReservationRepository(dbContext);
                }
                return reservationRepository;
            }
        }
        public void Save()
        {
            dbContext.SaveChanges();
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
