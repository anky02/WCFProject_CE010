using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ELSystem
{
    [DataContract]
    public class Tab
    {
        private int _tabid;
        private string _tabName;
        private string _tabUrl;
        private int _curid;

        [DataMember]
        public int TabId
        {
            get { return _tabid; }
            set { _tabid = value; }

        }
        [DataMember]
        public string TabName
        {
            get { return _tabName; }
            set { _tabName = value; }
        }
        [DataMember]
        public string TabUrl
        {
            get { return _tabUrl; }
            set { _tabUrl = value; }
        }
        [DataMember]
        public int CurId
        {
            get { return _curid; }
            set { _curid = value; }
        }
    }
}
