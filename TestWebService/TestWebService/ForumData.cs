using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestWebService
{
    [DataContract]
    public class UserData
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string firstname { get; set; }
        [DataMember]
        public string lastname { get; set; }
    }

    [DataContract]
    public class UsersData
    {
        [DataMember]
        public List<List> list { get; set; }
    }


    public class List
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
}
