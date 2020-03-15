using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindBot.Game
{
    public class ChainTarget
    {
        public ClientCard Target { get; set; }
        public ClientCard Targeting { get; set; }
        public int TargetingPlayer { get; set; }
    }
}
