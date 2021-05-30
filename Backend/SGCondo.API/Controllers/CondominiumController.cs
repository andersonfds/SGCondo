using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGCondo.API.UoW;
using SGCondo.API.ViewModels;
using SGCondo.Framework.Controller;
using System;
using System.Threading.Tasks;

namespace SGCondo.API.Controllers
{
    [ApiController, Route("[controller]")]
    public class CondominiumController : BaseController<CondominiumUoW>
    {
        public CondominiumController(CondominiumUoW uow, IMapper mapper) : base(uow, mapper)
        {
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(Guid id)
        {
            var result = await UoW.CondominiumBLL.GetOne(id);
            return Ok(Convert<CondominiumViewModel>(result));
        }
    }
}
