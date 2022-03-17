using System;
using System.Collections.Generic;

namespace WebReversaOracle.ObjetosEngenhariaReversa
{
    public partial class MviewAdvAjg
    {
        public MviewAdvAjg()
        {
            MviewAdvFjgs = new HashSet<MviewAdvFjg>();
        }

        public decimal Ajgid { get; set; }
        public decimal Runid { get; set; }
        public decimal Ajgdeslen { get; set; }
        public byte[] Ajgdes { get; set; } = null!;
        public decimal Hashvalue { get; set; }
        public decimal? Frequency { get; set; }

        public virtual MviewAdvLog Run { get; set; } = null!;
        public virtual ICollection<MviewAdvFjg> MviewAdvFjgs { get; set; }
    }
}
