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
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        
        UserService service;
        public UserController(ILogger<UserController> logger, RfContext context)
        {
            _logger = logger;
            service = new UserService(context);
        }
        // GET: api/User
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await service.GetUsersAsync();
        }
        
    }
}
