namespace Tehi
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
    }
}
