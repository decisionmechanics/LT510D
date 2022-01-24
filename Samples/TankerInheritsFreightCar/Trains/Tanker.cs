namespace Trains
{
    public class Tanker : FreightCar
    {
        private readonly double radius;
        public double Radius { get { return radius; } }

        public Tanker(string rn, int ln, int wd, int ht, int rd)
            : base(rn, ln, wd, ht)
        {
            //roadNumber = rn;
            //length = ln;
            //width = wd;
            //height = ht;
            radius = rd;
        }
    }
}
