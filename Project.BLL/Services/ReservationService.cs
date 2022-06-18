using AutoMapper;
using Project.BLL.Interfaces.Services;
using Project.DAL.Interfaces.Repositories;
using Project.DAL.Entities;
using Project.DAL.Interfaces.Repositories.Base;
using Project.BLL.DTO.Responses;
using Project.BLL.DTO.Requests;
using Project.DAL.Interfaces;

namespace Project.BLL.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly IReservationRepository reservationRepository;


        public async Task<IEnumerable<ReservationResponse>> GetAll()
        {
            var reservation = await reservationRepository.GetAll();
            return mapper.Map<List<ReservationResponse>>(reservation);
        }
        public async Task<ReservationResponse> GetById(int id)
        {
            var reservation = await reservationRepository.GetById(id);
            return mapper.Map<ReservationResponse>(reservation);
        }

        public void Insert(ReservationRequest request)
        {
            var reservation = mapper.Map<Reservation>(request);
            reservationRepository.Insert(reservation);
            unitOfWork.SaveChangesAsync();
        }

        public void Update(ReservationRequest request)
        {
            var review = mapper.Map<Reservation>(request);
            reservationRepository.Update(review);
            unitOfWork.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            reservationRepository.Delete(id);
            unitOfWork.SaveChangesAsync();
        }

        public ReservationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            reservationRepository = this.unitOfWork.ReservationRepository;
        }
    }
}