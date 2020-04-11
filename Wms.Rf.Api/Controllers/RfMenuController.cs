using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Wms.Rf.Api.Data;
using Wms.Rf.Api.Models;
using Wms.Rf.Api.Services;

namespace Wms.Rf.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RfMenuController : ControllerBase
    {
        private readonly ILogger<RfMenuController> _logger;

        RFMenuService service;
        public RfMenuController(ILogger<RfMenuController> logger, RfContext context)
        {
            _logger = logger;
            service = new RFMenuService(context);
        }
        // GET: api/RfMenu
        [HttpGet]
        public async Task<IEnumerable<RFMenu>> Get()
        {
            return await service.GetRFMenusAsync();
        }
        
    }
}
