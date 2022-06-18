using Project.DAL.Context;
using Project.DAL.Data.Repositories.Base;
using Project.DAL.Entities;
using Project.DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data.Repositories
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(CinemaDBContext dbContext) : base(dbContext)
        {
        }
        
    }
}
