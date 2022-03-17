using System;
using System.Collections.Generic;

namespace WebReversaOracle.ObjetosEngenhariaReversa
{
    public partial class Help
    {
        public string Topic { get; set; } = null!;
        public decimal Seq { get; set; }
        public string? Info { get; set; }
    }
}
