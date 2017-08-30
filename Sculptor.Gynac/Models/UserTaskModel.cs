using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sculptor.Gynac.Models
{
    public class UserTaskModel
    {
        public UserTaskModel()
        {
            UserSessionMaster = new List<SessionMasterModel>();
            UserModuleMaster = new List<ModuleMasterModel>();
            UserTalkMaster = new List<TalkMasterModel>();            
        }
        public List<SessionMasterModel> UserSessionMaster { get; set; }
        public List<ModuleMasterModel> UserModuleMaster { get; set; }
        public List<TalkMasterModel> UserTalkMaster { get; set; }     

    }    
}