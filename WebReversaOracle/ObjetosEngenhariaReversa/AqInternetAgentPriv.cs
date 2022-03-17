using System;
using System.Collections.Generic;

namespace WebReversaOracle.ObjetosEngenhariaReversa
{
    public partial class AqInternetAgentPriv
    {
        public string AgentName { get; set; } = null!;
        public string DbUsername { get; set; } = null!;

        public virtual AqInternetAgent AgentNameNavigation { get; set; } = null!;
    }
}
