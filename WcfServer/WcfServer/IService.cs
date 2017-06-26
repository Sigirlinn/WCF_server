using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServer
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Dictionary<int, User> getUserAll();

        [OperationContract]
        Dictionary<int, Mail> getMailAll();

        [OperationContract]
        Dictionary<int, Mail> getMailTwoUser(string login1, string login2);

        [OperationContract]
        Dictionary<int, User> checkUser(string login, string password);

        [OperationContract]
        int getUserId(string login);

        [OperationContract]
        string getUserName(string login);

        [OperationContract]
        void setMail(Mail sms);

        [OperationContract]
        void setUser(User user, string password);
    }
}
