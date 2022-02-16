using System;
using System.Collections.Generic;

namespace Tehi.TehiEntities
{
    public partial class Player
    {
        public string Name { get; set; } = null!;
        public int BestHandScore { get; set; }
        public int HandsDealt { get; set; }
    }
}
