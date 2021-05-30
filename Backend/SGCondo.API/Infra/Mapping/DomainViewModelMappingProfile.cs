using AutoMapper;
using SGCondo.API.ViewModels;
using SGCondo.Domain;

namespace SGCondo.API.Infra.Mapping
{
    public class DomainViewModelMappingProfile: Profile
    {
        public DomainViewModelMappingProfile()
        {
            #region Domain To ViewModel
            CreateMap<Apartment, ApartmentViewModel>().ReverseMap();
            CreateMap<Condominium, CondominiumViewModel>().ReverseMap();
            CreateMap<Resident, ResidentViewModel>().ReverseMap();
            #endregion Domain To ViewModel
        }
    }
}
