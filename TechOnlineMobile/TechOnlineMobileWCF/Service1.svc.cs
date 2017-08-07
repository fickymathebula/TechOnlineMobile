using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TechOnlineMobileWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        TechOnlineDbEntities obj = new TechOnlineDbEntities();

        // Clents
        public List<UserAccount> getUsers()
        {
            var results = from n in obj.UserAccounts select n;
            return results.ToList<UserAccount>();
        }

        public bool getLoginUser(string email, string password)
        {
            bool found = false;

            var results = obj.UserAccounts.Where(x => x.Email == email && x.Password == password);
            results.ToList<UserAccount>();

            if (results.Count() == 1)
            {
                found = true;                
            }

            return found; 
        }
       
        public void addUser(string strName, string strSurname, string strEmail, string strphoneNumber, DateTime dateOfBirth, bool isActive, int roleId, string strPassword, DateTime capturedDate, int genderId)
        {
            UserAccount user = new UserAccount
            {
                FirstName = strName,
                LastName = strSurname,
                Email = strEmail,
                PhoneNumber = strphoneNumber,
                DateOfBirth = dateOfBirth,
                Active = isActive,
                RoleId = roleId,
                Password = strPassword,
                CapturedDate = capturedDate,
                GenderId = genderId

            };

            obj.UserAccounts.Add(user);
            obj.SaveChanges();
        }

        public void editUser(string strName, string strSurname, string strEmail, string strphoneNumber, DateTime dateOfBirth, bool isActive, int roleId, string strPassword, DateTime capturedDate, int genderId)
        {
            UserAccount client = new UserAccount
            {
                FirstName = strName,
                LastName = strSurname,
                Email = strEmail,
                PhoneNumber = strphoneNumber,
                DateOfBirth = dateOfBirth,
                Active = isActive,
                RoleId = roleId,
                Password = strPassword,
                CapturedDate = capturedDate,
                GenderId = genderId
            };

            obj.Entry(client).State = EntityState.Modified;
            obj.SaveChanges();
        }
        public void deleteUser(int ClientId)
        {
            UserAccount results = obj.UserAccounts.Find(ClientId);
            obj.UserAccounts.Remove(results);
            obj.SaveChanges();
        }

        public UserAccount getUserDetails(int id)
        {
            return obj.UserAccounts.Find(id);
        }
    }
}
