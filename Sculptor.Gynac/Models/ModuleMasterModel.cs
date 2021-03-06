﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sculptor.Gynac.Models
{
    //this model using for active and inactive talks
    public class ModuleMasterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SessionId { get; set; }
        public bool IsModuleChecked { get; set; }        
    }

    //this  model using for images
    public class ModuleWithImage 
    {
        public ModuleWithImage()
        {
            ModuleSampleImages = new List<ModuleSampleImages>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SessionId { get; set; }
        public bool IsModuleChecked { get; set; }
        public List<ModuleSampleImages> ModuleSampleImages { get; set; }
    }

    public class ModuleSampleImages
    {
        public int Id { get; set; }
        public string SampleImage { get; set; }
        public string Description { get; set; }
        public int? ModulId { get; set; }        
    }

    public class ModuleUploadSampleImages
    {
        public int Id { get; set; }
        public string SampleImage { get; set; }
        public string Description { get; set; }
        public int? ModulId { get; set; }
        public string ModulName { get; set; }
    }
    
    public class UserSampleImages
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int?  IsStatus{ get; set; }
        public string Comment { get; set; }
        public int? ModulId { get; set; }
        public int? UserId { get; set; }
        public int? FacultyId { get; set; }
        public int? ModuleImageId { get; set; }        
    }

    public class ModuleDetailsModel
    {
        public ModuleDetailsModel()
        {
            Module = new ModuleWithImage();
            UserModuleImages = new List<UserSampleImages>();
        }
        public ModuleWithImage Module { get; set; }
        public List<UserSampleImages> UserModuleImages { get; set; }
    }
}