using System;
using System.Collections.Generic;
using System.Text;

namespace HydraBalancer
{
    public class MBingo
    {
        public string name { get; set; }
        public int port { get; set; } = 0;
        public string ip { get; set; }
        public int status { get; set; } = 2; //OUT_OF_SERVICE, DOWN, STARTING, UNKNOWN y UP.
    }
}