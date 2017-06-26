using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfServer
{
    [DataContract]
    public class User
    {

        [DataMember]
        public string Login
        {
            get; set;
        }

        [DataMember]
        public string Name
        {
            get; set;
        }
    }
}
