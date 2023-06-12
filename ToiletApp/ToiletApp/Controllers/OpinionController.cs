using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToiletApp.Logic;
using ToiletApp.Models;

namespace ToiletApp.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OpinionController : Controller
    {
        IToiletAppLogic _logic;
        private readonly UserManager<SiteUser> _userManager;

        public OpinionController(UserManager<SiteUser> userManager, IToiletAppLogic logic)
        {
            this._logic = logic;
            _userManager = userManager;
        }

        [HttpGet("{toiletUid}")]
        public IEnumerable<Opinion> GetOpinions(string toiletUid)
        {

            return _logic.ListOpinions(toiletUid);
        }

        [HttpPost]
        public void AddOpinion(Opinion opinion)
        {
            _logic.AddOpinion(opinion);
        }

        [HttpDelete]
        public void DeleteOpinion(string tuid, string ouid)
        {
            _logic.DeleteOpinion(tuid, ouid, _userManager.GetUserId(this.User));
        }
    }
}
