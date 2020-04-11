using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wms.Rf.Api.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public int StoreId { get; set; }
        public string UserName { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public UserGroup UserGroup { get; set; }
        public List<UserRFMenu> UserRFMenus { get; set; }   
    }
}
