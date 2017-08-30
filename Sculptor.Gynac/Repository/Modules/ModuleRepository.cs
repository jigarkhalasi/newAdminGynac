using Sculptor.Gynac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Sculptor.Gynac.Repository.Modules
{
    public class ModuleRepository : BaseRepository, IModuleRepository
    {
        public async Task<IEnumerable<ModuleUploadSampleImages>> GetAllSampleImages()
        {
            return await Task.Run(() =>
            {
                var ModuleList = new List<ModuleUploadSampleImages>();
                var data = _contex.ModuleImages;
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        var model = new ModuleUploadSampleImages();
                        model.Id = item.Id;
                        model.SampleImage = item.SampleImage;
                        model.Description = item.Description;
                        model.ModulId = item.ModulId;
                        model.ModulName = item.ModuleMaster.Name;
                        ModuleList.Add(model);
                    }
                }

                return ModuleList.ToList();
            });
        }

        //public Task<IQueryable<ModuleMaster>> GetAllSampleImages()
        //{

        //    throw new NotImplementedException();
        //   // return await Task.Run(() =>
        //   //{
        //   //    return _contex.ModuleImages.ToList();
        //   //});
        //}

        public Task<bool> UploadSampleImages(ModuleUploadSampleImages model)
        {
            throw new NotImplementedException();
        }
    }
}