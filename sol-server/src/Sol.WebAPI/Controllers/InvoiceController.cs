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

        // GET api/values
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

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
