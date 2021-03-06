//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sculptor.Gynac.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModuleMaster
    {
        public ModuleMaster()
        {
            this.ModuleImages = new HashSet<ModuleImage>();
            this.TalkMasters = new HashSet<TalkMaster>();
            this.UserModuleImages = new HashSet<UserModuleImage>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> SessionId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> FacultyId { get; set; }
    
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<ModuleImage> ModuleImages { get; set; }
        public virtual SessionMaster SessionMaster { get; set; }
        public virtual ICollection<TalkMaster> TalkMasters { get; set; }
        public virtual ICollection<UserModuleImage> UserModuleImages { get; set; }
    }
}
