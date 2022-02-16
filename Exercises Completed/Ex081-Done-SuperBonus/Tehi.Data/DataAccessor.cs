namespace Tehi.Data
{
    using TehiEntities;

    public class DataAccessor
    {
        private TehiEntitiesContext db = new TehiEntitiesContext();

        public List<Player> Top10Players
        {
            get
            {
                IEnumerable<Player> result = 
                    from p in db.Players 
                    where p.BestHandScore != 0
                    orderby p.BestHandScore descending, p.HandsDealt
                    select p;

                return result.Take(10).ToList();
            }
        }

        public Player? LookupPlayer(string name)
        {
            IEnumerable<Player> result = 
                from p in db.Players
                where p.Name.Trim().ToUpper() == name.Trim().ToUpper()
                select p;

            return result.FirstOrDefault();
        }

        public void Add(Player player)
        {
            db.Players.Add(player);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
