using Project.BLL.DTO.Requests;
using Project.BLL.DTO.Responses;

namespace Project.BLL.Interfaces.Services
{

    public interface IReservationService
    {
        Task<IEnumerable<ReservationResponse>> GetAll();

       
        Task<ReservationResponse> GetById(int id);
        void Insert(ReservationRequest request);
        void Update(ReservationRequest request);
        void Delete(int id);
    }
}