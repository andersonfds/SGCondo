using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGCondo.API.UoW;
using SGCondo.API.ViewModels;
using SGCondo.API.ViewModels.Filter;
using SGCondo.Framework.Controller;
using SGCondo.Framework.Service;
using SGCondo.Repository.Infra.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SGCondo.API.Controllers
{
    [ApiController, Route("[controller]")]
    public class CondominiumController : BaseController<CondominiumUoW>
    {

        public class TestModel
        {
            [Required]
            public string Te { get; set; }
        }

        public CondominiumController(CondominiumUoW uow, IMapper mapper, IErrorNotification notification) : base(uow, mapper, notification)
        {
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(Guid id)
        {
            var result = await UoW.CondominiumBLL.GetOne(id);
            return Convert<CondominiumViewModel>(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] CondominiumQuerySpecViewModel querySpec)
        {
            var querySpecData = Mapper.Map<CondominiumQuerySpec>(querySpec);
            var output = await UoW.CondominiumBLL.GetAll(querySpecData);
            return Convert<IEnumerable<CondominiumViewModel>>(output);
        }
    }
}
