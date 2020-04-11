using System;
using System.Collections.Generic;
using System.Text;

namespace Wms.Rf.Api.Models
{
    public class UserRFMenu
    {        
        public int StoreId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int MenuId { get; set; }        
        public RFMenu Menu { get; set; }
    }
}
