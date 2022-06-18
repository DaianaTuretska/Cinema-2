using AutoMapper;
using Project.BLL.DTO.Requests;
using Project.BLL.DTO.Responses;
using Project.DAL.Entities;


namespace Project.BLL.Configuration.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        private void CreatePlaceMaps()
        {
            CreateMap<Place, PlaceResponse>();
            CreateMap<PlaceRequest, Place>();
        }
        private void CreateReservationMaps()
        {
            CreateMap<Reservation, ReservationResponse>();
            CreateMap<ReservationRequest, Reservation>();
        }

        public AutoMapperProfile()
        {
            CreatePlaceMaps();
            CreateReservationMaps();
        }

    }
}
