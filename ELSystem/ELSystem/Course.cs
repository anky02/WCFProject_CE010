using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ELSystem
{
    [DataContract]
    public class Course
    {
        private int _id;
        private string _curName;
        private int _curTabid;

        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }
        [DataMember]
        public string CurName
        {
            get { return _curName; }
            set { _curName = value; }
        }
        [DataMember]
        public int NumberofTab
        {
            get { return _curTabid; }
            set { _curTabid = value; }
        }
    }
}
