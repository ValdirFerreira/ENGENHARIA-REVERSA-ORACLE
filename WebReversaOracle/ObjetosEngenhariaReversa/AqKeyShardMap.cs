﻿using System;
using System.Collections.Generic;

namespace WebReversaOracle.ObjetosEngenhariaReversa
{
    public partial class AqKeyShardMap
    {
        public decimal Queue { get; set; }
        public string Key { get; set; } = null!;
        public decimal Shard { get; set; }
        public decimal DelayShard { get; set; }
    }
}
