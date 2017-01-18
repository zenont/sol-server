using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc.Ext;
using Sol.Services.Interfaces;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Sol.Common;
using Sol.DTO;
using Sol.Entities;

namespace Sol.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class InvoiceController : ApiControllerBase
    {
        public InvoiceController(
            IMapper mapper,
            IInvoiceService invoiceService, 
            ILogger<InvoiceController> log)
        {
            Mapper = mapper;
            InvoiceService = invoiceService;
            Log = log;
        }

        protected IMapper Mapper { get; set; }

        protected IInvoiceService InvoiceService { get; set; }

        protected ILogger<InvoiceController> Log { get; set; }

        [HttpGet]
        public async Task<IActionResult> GetAsync(
            [FromQuery] int? deliveryPointId = null,
            [FromQuery] int? zoneId = null,
            [FromQuery] DateTime? start = null,
            [FromQuery] DateTime? end = null,
            [FromQuery(Name = "state")] EvaluationStates? evaluationState = null,
            [FromQuery] string orderBy = "Start",
            [FromQuery] bool? isAsc = true,
            [FromQuery] int? skip = 0,
            [FromQuery] int? take = 100)
        {
            var entities = await InvoiceService.GetInvoiceAsync(deliveryPointId, zoneId, start, end, evaluationState, orderBy, isAsc, skip, take);
            var mapped = Mapper.Map<IEnumerable<InvoiceDTO>>(entities);
            return OkWrapped(mapped);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> FindByIdAsync(int id)
        {
            var entity = await InvoiceService.FindInvoiceByIdAsync(id);
            var mapped = Mapper.Map<InvoiceDTO>(entity);
            return OkWrapped(mapped);
        }

        [HttpPost]
        public async Task<IActionResult> SaveAsync([FromBody]InvoiceDTO dto)
        {
            // if the entity is not new, we first check if it exists
            if(!dto.IsNew && !await InvoiceService.CheckInvoiceExistsByIdAsync(dto.Id))
            {
                return NotFound();
            }

            Invoice entity = Mapper.Map<Invoice>(dto);
            var errors = await InvoiceService.ValidateInvoiceAsync(entity);
            if(errors.Any())
            {
                return BadRequestWrapped(errors);
            }

            entity = await InvoiceService.SaveInvoiceAsync(entity);
            var mapped = Mapper.Map<InvoiceDTO>(entity);
            return OkWrapped(mapped);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            Invoice entity = await InvoiceService.FindInvoiceByIdAsync(id);
            if (entity == null)
            {
                return Ok();
            }

            await InvoiceService.DeleteInvoiceAsync(entity);
            return Ok();
        }
    }
}
