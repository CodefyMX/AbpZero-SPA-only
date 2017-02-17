using Abp.Web.Models;
using Abp.Web.Mvc.Authorization;
using Cinotam.AbpModuleZero.Authorization;
using Cinotam.AbpModuleZero.Tools.DatatablesJsModels.GenericTypes;
using Cinotam.AbpModuleZero.Web.Controllers;
using Cinotam.ModuleZero.AppModule.Users;
using System.Web.Mvc;

namespace Cinotam.AbpModuleZero.Web.Areas.AngularApi.Controllers
{
    public class UsersController : AbpModuleZeroControllerBase
    {
        // GET: AngularApi/Users
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        [AbpMvcAuthorize(PermissionNames.PagesSysAdminUsers)]
        [WrapResult(false)]
        public ActionResult LoadUsers(RequestModel<object> input, string propToSearch, string[] requestedProps, bool isPost)
        {
            ProccessQueryData(input, propToSearch, requestedProps, isPost);
            var result = _userAppService.GetUsersForTable(input);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}