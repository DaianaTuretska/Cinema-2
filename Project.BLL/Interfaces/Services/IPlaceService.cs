using Project.BLL.DTO.Requests;
using Project.BLL.DTO.Responses;

namespace Project.BLL.Interfaces.Services
{

    public interface IPlaceService
    {
        Task<IEnumerable<PlaceResponse>> GetAll();

        Task<PlaceResponse> GetById(int id);
        void Insert(PlaceRequest request);
        void Update(PlaceRequest request);
        void Delete(int id);
    }
}