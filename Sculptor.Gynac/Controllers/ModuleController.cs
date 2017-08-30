using Sculptor.Gynac.Repository.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sculptor.Gynac.Controllers
{
    public class ModuleController : BaseController
    {
        private readonly IModuleRepository _moduleRepository;

        public ModuleController()
        {
            _moduleRepository = new ModuleRepository();
           
        }

        // GET: Module
        public async Task<ActionResult> Index()
        {
            //var data = await _moduleRepository.GetAllSampleImages();
            ////var ModuleData = await _moduleRepository.GetAllModule();
            ////var data1 = ModuleData.ToList().Select(u => new UserModelSelect()
            ////{
            ////    UserId = u.User_Id,
            ////    UserName = u.First_Name
            ////}).ToList();
            //ViewBag.UserList = new MultiSelectList(data1, "UserId", "UserName");
            //return View(data);
            return View();
        }
    }
}