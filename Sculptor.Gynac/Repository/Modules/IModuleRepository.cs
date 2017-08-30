using Sculptor.Gynac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sculptor.Gynac.Repository.Modules
{
    public interface IModuleRepository
    {
        Task<IEnumerable<ModuleUploadSampleImages>> GetAllSampleImages();

        //Task<IEnumerable<ModuleImage>> GetAllModule();
        

        Task<bool> UploadSampleImages(ModuleUploadSampleImages model);
    }
}
