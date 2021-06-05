using AutoMapper;
using SGCondo.API.ViewModels;
using SGCondo.API.ViewModels.Filter;
using SGCondo.Domain;
using SGCondo.Repository.Infra.Filters;

namespace SGCondo.API.Infra.Mapping
{
    public class DomainViewModelMappingProfile : Profile
    {
        public DomainViewModelMappingProfile()
        {
            #region Domain To ViewModel
            CreateMap<Apartment, ApartmentViewModel>().ReverseMap();
            CreateMap<Condominium, CondominiumViewModel>().ReverseMap();
            CreateMap<Resident, ResidentViewModel>().ReverseMap();
            CreateMap<CondominiumQuerySpec, CondominiumQuerySpecViewModel>().ReverseMap();
            #endregion Domain To ViewModel
        }
    }
}
