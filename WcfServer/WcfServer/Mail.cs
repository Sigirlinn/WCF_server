using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WcfServer
{
    [DataContract]
    public class Mail
    {
        [DataMember]
        public string Title
        {
            get; set;
        }

        [DataMember]
        public DateTime Date
        {
            get; set;
        }

        [DataMember]
        public string Sender
        {
            get; set;
        }

        [DataMember]
        public string Recipient
        {
            get; set;
        }

        [DataMember]
        public string Text
        {
            get; set;
        }
    }
}
