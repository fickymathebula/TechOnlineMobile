using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TechOnlineMobileWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<UserAccount> getUsers();

        [OperationContract]
        bool getLoginUser(string email, string password);

        [OperationContract]
        UserAccount getUserDetails(int id);

        [OperationContract]
        void addUser(string strName, string strSurname, string strEmail, string strphoneNumber, DateTime dateOfBirth, bool isActive, int roleId, string strPassword, DateTime capturedDate, int genderId);
        
        [OperationContract]
        void editUser(string strName, string strSurname, string strEmail, string strphoneNumber, DateTime dateOfBirth, bool isActive, int roleId, string strPassword, DateTime capturedDate, int genderId);

        [OperationContract]
        void deleteUser(int clientId);

    }


    
}
