using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGCondo.Framework.Service;
using SGCondo.Framework.UoW;

namespace SGCondo.Framework.Controller
{
    public class BaseController<TUoW> : ControllerBase where TUoW : BaseUoW
    {
        protected readonly TUoW UoW;
        protected readonly IMapper Mapper;
        protected readonly IErrorNotification ErrorNotification;

        public BaseController(TUoW uow, IMapper mapper, IErrorNotification errorNotification)
        {
            UoW = uow;
            Mapper = mapper;
            ErrorNotification = errorNotification;
        }

        protected IActionResult Convert<TDestination>(dynamic result)
        {

            if (ErrorNotification.Has())
            {
                var error = ErrorNotification.Get();
                var output = new ObjectResult(error)
                {
                    StatusCode = error.Code,
                };
                return output;
            }


            return Ok(Mapper.Map<TDestination>(result));
        }
    }
}
