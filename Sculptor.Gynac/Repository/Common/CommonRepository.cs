using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Sculptor.Gynac.Models.Enum;
using Sculptor.Gynac.Models;

namespace Sculptor.Gynac.Repository.Common
{
    public class CommonRepository : BaseRepository , ICommonRepository
    {
        public async Task<IQueryable<SessionMaster>> GetAllSession()
        {
            return await Task.Run(() =>
            {
                return _contex.SessionMasters;
            });
        }

        public async Task<IQueryable<ModuleMaster>> GetAllModule(int sessionId)
        {            
            return await Task.Run(() =>
            {
                return _contex.ModuleMasters.Where(m => m.SessionId == sessionId);
            });
        }


        public async Task<IQueryable<TalkMaster>> GetAllTalks(int sessionId, int moduleId)
        {
            return await Task.Run(() =>
            {
                return _contex.TalkMasters.Where(m => m.SessionId == sessionId && m.ModulId == moduleId );
            });
        }


        public async Task<ModuleMaster> GetModuleById(int moduleId)
        {
            return await _contex.ModuleMasters.FindAsync(moduleId);
        }

        public async Task<IQueryable<ModuleImage>> GetModuleImageByModuleId(int moduleId)
        {
            return await Task.Run(() =>
            {
                return _contex.ModuleImages.Where(m => m.ModulId == moduleId);
            });
        }

        //public async Task<IQueryable<UserModuleImage>> GetUserModuleImageByModuleId(int moduleId, int userId, int facultyId)
        //{
        //    return await Task.Run(() =>
        //    {
        //        return _contex.UserModuleImages.Where(m => m.UserId == userId && m.ModulId == moduleId && m.Faculty_Id == facultyId);
        //    });
        //}
       
    }
}