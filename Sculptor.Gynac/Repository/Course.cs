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
    
    public partial class Course
    {
        public Course()
        {
            this.User_Course = new HashSet<User_Course>();
        }
    
        public int Course_Id { get; set; }
        public int Faculty_Id { get; set; }
        public string Course_Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Fees { get; set; }
        public string Currency { get; set; }
        public int Validity_Days { get; set; }
        public System.DateTime Insert_Date { get; set; }
        public System.DateTime Update_Date { get; set; }
    
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<User_Course> User_Course { get; set; }
    }
}
