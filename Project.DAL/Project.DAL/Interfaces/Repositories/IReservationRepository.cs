using Project.DAL.Entities;
using Project.DAL.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Interfaces.Repositories
{
    public interface IReservationRepository : IGenericRepository<Reservation>
    {
    }
}
