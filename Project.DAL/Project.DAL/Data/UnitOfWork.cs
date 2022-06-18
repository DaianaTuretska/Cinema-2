using Project.DAL.Context;
using Project.DAL.Interfaces;
using Project.DAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly CinemaDBContext context;

        public IReservationRepository ReservationRepository { get; }
        public IPlaceRepository PlaceRepository { get; }


        public async Task SaveChangesAsync() => await context.SaveChangesAsync();


        public UnitOfWork
        (
        CinemaDBContext context,
        IReservationRepository reservationRepository,
        IPlaceRepository placeRepository
        )
        {
            this.context = context;
            ReservationRepository = reservationRepository;
            PlaceRepository =placeRepository;
        }


    }
}
