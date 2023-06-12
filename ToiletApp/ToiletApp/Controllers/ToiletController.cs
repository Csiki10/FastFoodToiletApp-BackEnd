using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ToiletApp.Models;

namespace ToiletApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToiletController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Toilet> GetToilets()
        {
            return repository.ListToilets();
        }

        [HttpGet("{id}")]
        public Toilet? GetToilet(string id)
        {
            return repository.GetToilets(id);
        }

        [HttpPost]
        public void AddToilet([FromBody] Toilet t)
        {
            repository.AddToilet(t);
        }

        [HttpPut]
        public void EditToilet([FromBody] Toilet t)
        {
            repository.EditToilet(t);
        }

        [HttpDelete("{id}")]
        public void DeleteToilet(string id)
        {
            repository.Delete(id);
        }
    }
}
