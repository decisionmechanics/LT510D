namespace Tehi.TehiEntities
{
    public partial class Player
    {
        public override string ToString()
        {
            return $"{Name} {BestHandScore} {HandsDealt}";
        }
    }
}
