using ToiletApp.Data;
using ToiletApp.Models;

namespace ToiletApp.Logic
{
    public class ToiletAppLogic : IToiletAppLogic
    {
        ApplicationDbContext db;

        public ToiletAppLogic(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Toilet> GetAllToilets()
        {
            return db.Toilets;
        }

        public Toilet? GetToilet(string id)
        {
            return db.Toilets.FirstOrDefault(t => t.Uid == id);
        }

        public void AddNewToilet(Toilet t)
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

        public void UpdateToilet(Toilet t)
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

        public void DeleteToilet(string id)
        {
            var toilet = db.Toilets.FirstOrDefault(t => t.Uid == id);
            if (toilet != null)
            {
                db.Toilets.Remove(toilet);
                db.SaveChanges();
            }
        }

        public IEnumerable<Opinion> ListOpinions(string toiletUid)
        {
            var toilet = db.Toilets.FirstOrDefault(t => t.Uid == toiletUid);
            if (toilet == null)
            {
                return Enumerable.Empty<Opinion>();
            }
            else
            {
                return toilet.Opinions;
            }
        }

        public void AddOpinion(Opinion opinion)
        {
            var toilet = db.Toilets.FirstOrDefault(t => t.Uid == opinion.ToiletUid);
            if (toilet == null)
            {

            }
            else
            {
                opinion.Toilet = toilet;
                db.Opinions.Add(opinion);
                db.SaveChanges();
            }
        }

        public void DeleteOpinion(string tuid, string ouid, string u)
        {
            var toilet = db.Toilets.FirstOrDefault(t => t.Uid == tuid);
            if (toilet != null)
            {
                var op = toilet.Opinions.FirstOrDefault(o => o.Uid == ouid);

                if (op != null && op.Toilet.UserId == u)
                {
                    db.Opinions.Remove(op);
                    db.SaveChanges();
                }
            }
        }

        public void UpdateOpinion(Opinion opinion)
        {
            var old = db.Opinions.FirstOrDefault(x => x.Uid == opinion.Uid);
            if (old != null)
            {
                old.Stars = opinion.Stars;
                old.Date = opinion.Date;
                old.Description = opinion.Description;

                db.SaveChanges();
            }
        }
    }
}
