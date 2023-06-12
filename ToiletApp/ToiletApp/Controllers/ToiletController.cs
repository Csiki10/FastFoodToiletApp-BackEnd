using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Text.RegularExpressions;
using ToiletApp.Data;
using ToiletApp.Models;

namespace ToiletApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToiletController : ControllerBase
    {
        ApplicationDbContext db;
        UserManager<SiteUser> _userManager;

        public ToiletController(ApplicationDbContext db, UserManager<SiteUser> userManager)
        {
            this.db = db;
            _userManager = userManager;
        }

        [HttpGet]
        [Authorize]
        //[Route("getToilets")]
        public IEnumerable<Toilet> GetToilets()
        {
            return db.Toilets;
            //asd
        }

        [HttpGet("{id}")]
        //[Route("getToilet")]
        public Toilet? GetToilet(string id)
        {
            return db.Toilets.FirstOrDefault(t => t.Uid == id);

        }

        [HttpPost]
        //[Route("addToilet")]
        public void AddToilet([FromBody] Toilet t)
        {
            if (t.Uid == null)
            {
                t.Uid = Guid.NewGuid().ToString();
            }
            var old = db.Toilets.FirstOrDefault(t => t.Equals(t));
            if (old == null)
            {
                db.Toilets.Add(t);
                db.SaveChanges();
            }
        }

        [HttpPut]
        [Route("editToilet")]
        public void EditToilet([FromBody] Toilet t)
        {
            var old = db.Toilets.FirstOrDefault(x => x.Uid == t.Uid);
            if (old != null)
            {
                old.Code = t.Code;
                old.Institution = t.Institution;

                if (old.Address != null)
                {
                    old.Address.City = t.Address.City;
                    old.Address.Street = t.Address.Street;
                    old.Address.PostCode = t.Address.PostCode;
                }

                db.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        //[Route("deleteToilet")]
        public void DeleteToilet(string id)
        {
            var toilet = db.Toilets.FirstOrDefault(t => t.Uid == id);
            if (toilet != null )
            {
                db.Toilets.Remove(toilet);
                db.SaveChanges();
            }
        }
    }
}
