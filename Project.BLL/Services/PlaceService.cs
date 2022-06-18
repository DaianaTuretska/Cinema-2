using AutoMapper;
using Project.BLL.Interfaces.Services;
using Project.DAL.Interfaces.Repositories;
using Project.DAL.Entities;
using Project.BLL.DTO.Responses;
using Project.BLL.DTO.Requests;
using Project.DAL.Interfaces;

namespace Project.BLL.Services
{
    public class PlaceService : IPlaceService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly IPlaceRepository placeRepository;


        public async Task<IEnumerable<PlaceResponse>> GetAll()
        {
            var review = await placeRepository.GetAll();
            return mapper.Map<List<PlaceResponse>>(review);
        }
        public async Task<PlaceResponse> GetById(int id)
        {
            var review = await placeRepository.GetById(id);
            return mapper.Map<PlaceResponse>(review);
        }

        public void Insert(PlaceRequest request)
        {
            var review = mapper.Map<Place>(request);
            placeRepository.Insert(review);
            unitOfWork.SaveChangesAsync();
        }

        public void Update(PlaceRequest request)
        {
            var review = mapper.Map<Place>(request);
            placeRepository.Update(review);
            unitOfWork.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            placeRepository.Delete(id);
            unitOfWork.SaveChangesAsync();
        }

        public PlaceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            placeRepository = this.unitOfWork.PlaceRepository;
        }
    }
}
