using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wms.Rf.Api.Data;
using Wms.Rf.Api.Models;

namespace Wms.Rf.Api.Services
{
    public class UserService
    {
        private readonly RfContext _context;

        public UserService(RfContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
