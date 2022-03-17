using System;
using System.Collections.Generic;

namespace WebReversaOracle.ObjetosEngenhariaReversa
{
    public partial class MviewAdvLevel
    {
        public MviewAdvLevel()
        {
            MviewAdvRollupMviewAdvLevelNavigations = new HashSet<MviewAdvRollup>();
            MviewAdvRollupMviewAdvLevels = new HashSet<MviewAdvRollup>();
        }

        public decimal Runid { get; set; }
        public decimal Levelid { get; set; }
        public decimal? Dimobj { get; set; }
        public decimal Flags { get; set; }
        public decimal Tblobj { get; set; }
        public byte[] Columnlist { get; set; } = null!;
        public string? Levelname { get; set; }

        public virtual MviewAdvLog Run { get; set; } = null!;
        public virtual ICollection<MviewAdvRollup> MviewAdvRollupMviewAdvLevelNavigations { get; set; }
        public virtual ICollection<MviewAdvRollup> MviewAdvRollupMviewAdvLevels { get; set; }
    }
}
