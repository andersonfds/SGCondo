using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGCondo.Framework.UoW;

namespace SGCondo.Framework.Controller
{
    public class BaseController<TUoW> : ControllerBase where TUoW : BaseUoW
    {
        protected readonly TUoW UoW;
        protected readonly IMapper Mapper;

        public BaseController(TUoW uow, IMapper mapper)
        {
            UoW = uow;
            Mapper = mapper;
        }

        protected object Convert<TDestination>(dynamic result)
        {
            return Mapper.Map<TDestination>(result);
        }
    }
}
