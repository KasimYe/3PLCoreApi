using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wms.Rf.Api.Data;
using Wms.Rf.Api.Models;

namespace Wms.Rf.Api.Services
{
    public class RFMenuService
    {
        private readonly RfContext _context;

        public RFMenuService(RfContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<RFMenu>> GetRFMenusAsync()
        {
            return await _context.RFMenu.ToListAsync();
        }

        public async Task<IEnumerable<RFMenu>> GetUserRFMenusAsync(int userId)
        {
            return await _context.RFMenu
                .Include(x => x.UserRFMenu)
                .Where(x => x.UserRFMenu.UserId == userId)
                .ToListAsync();
        }
    }
}
