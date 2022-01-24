namespace Trains
{
    public class FreightCar
    {
        private readonly int length, width, height;
        private readonly string roadNumber;
        public string RoadNumber { get { return roadNumber; } }

        public FreightCar(string rn, int ln, int wd, int ht)
        {
            roadNumber = rn;
            length = ln;
            width = wd;
            height = ht;
        }
    }
}
