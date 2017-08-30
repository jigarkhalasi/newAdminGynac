using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sculptor.Gynac.Models
{
    public class SessionMasterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSessionChecked { get; set; }        
    }
}