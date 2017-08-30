using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Sculptor.Gynac.Repository.UserTalks
{
    public class UserTalksRepository : BaseRepository, IUserTalksRepository
    {
        public async Task<IQueryable<UserTalk>> SetUserTalks(Int32 userId, List<int> talksId, string endDate)
        {
            return await Task.Run(() =>
            {

                var userTalksdata = _contex.UserTalks.Where(t => t.UserId == userId);
                _contex.UserTalks.RemoveRange(userTalksdata);
                _contex.SaveChanges();

                if (talksId != null)
                {

                    foreach (var item in talksId)
                    {
                        var dataModel = new UserTalk();
                        dataModel.Enddate = DateTime.ParseExact(endDate, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        dataModel.TalkId = item;
                        dataModel.UserId = userId;
                        _contex.UserTalks.Add(dataModel);

                    }
                    _contex.SaveChanges();
                }

                return _contex.UserTalks.Where(t => t.UserId == userId);
            });

        }


        public async Task<bool> IsUserTalksExits(int userId)
        {
            return await Task.Run(() =>
            {
                var data = _contex.UserTalks.Where(t => t.UserId == userId);
                return (data.ToList().Count > 0 ? true : false);
            });
        }


        public async Task<IQueryable<UserTalk>> GetUserTalks(int userId)
        {
            return await Task.Run(() =>
            {
                var data = _contex.UserTalks.Where(t => t.UserId == userId);
                return data;
            });
        }


        public async Task<bool> DeleteUserTalksExits(int userId)
        {
            return await Task.Run(() =>
            {
                var data = _contex.UserTalks.Where(t => t.UserId == userId);
                _contex.UserTalks.RemoveRange(data);

                return (_contex.SaveChanges() > 0 ? true : false);
            });
        }
    }
}