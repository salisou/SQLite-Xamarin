using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Classes
{
    public class TabOpzG3Ce
    {
        [PrimaryKey]
        public int PZUtente { get; set; } 
        [MaxLength(3)]
        public string PZDefCau { get; set; }
        public string PZInetURL { get; set; }
        public string PZInetLogin { get; set; }
        public string PZInetPsw { get; set; }
        public string PZPublisher { get; set; }
        public string PZPubLogin { get; set; }
        public string PZPubPsw { get; set; }
        public string PZDBp { get; set; }
        public string PZPublic { get; set; }
        public int PZCmpLev { get; set; }
        public int PZRtryTO { get; set; }
        public int PZQryTO { get; set; }
        public int PZCnnTO { get; set; }
        [MaxLength(4)]
        public int PZEType { get; set; }
        public byte PZFntBold { get; set; }
        public DateTime PZDtUltSincr { get; set; }
        public int PZBilanciaCode { get; set; }
        public DateTime PZDtUltMod { get; set; }

        public TabOpzG3Ce()
        {
                
        }
    }
}
