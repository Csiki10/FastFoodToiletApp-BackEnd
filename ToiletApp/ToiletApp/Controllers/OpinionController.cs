using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpGet("{toiletUid}")]
        public IEnumerable<Opinion> GetOpinions(string toiletUid)
        {
            return _logic.ListOpinions(toiletUid);
        }

        [Authorize]
        [HttpPost]
        public void AddOpinion(Opinion opinion)
        {
            _logic.AddOpinion(opinion);
        }

        [HttpPut]
        public void EditOpinion(Opinion opinion)
        {
            _logic.UpdateOpinion(opinion);
        }

        [HttpDelete]
        public void DeleteOpinion(string tuid, string ouid)
        {
            _logic.DeleteOpinion(tuid, ouid);
        }
    }
}
