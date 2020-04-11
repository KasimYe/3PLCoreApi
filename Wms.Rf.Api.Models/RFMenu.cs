using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wms.Rf.Api.Models
{
    public class RFMenu
    {
        [Key]
        public int MenuId { get; set; }
        public int MenuSort { get; set; }
        public string MenuText { get; set; }
        public bool Visible { get; set; }
        public string Url { get; set; }
        public bool Bottom { get; set; }
        public UserRFMenu UserRFMenu { get; set; }
    }
}
