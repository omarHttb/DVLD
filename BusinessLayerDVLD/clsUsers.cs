using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsUsers
    {
       public enum  _enMode { AddNewMode , UpdateMode }

        public static _enMode Mode = _enMode.AddNewMode;
        public  int UserID { get; set; }
        public  int PersonID { get; set; }
        public  string UserName { get; set; }
        public  string Password { get; set; }
        public  short IsActive {  get; set; }
        public string isActiveString { get; set; }   
        clsUsers(int userId,string userName,string isActive,int personId) 
        {
            UserID = userId;
            UserName = userName;
            isActiveString = isActive;
            PersonID = personId;    

        }
        public clsUsers() 
        {
            UserID = -1;
            PersonID=-1;
            UserName = "";
            Password = "";
            IsActive = -1;
            isActiveString = "";
        }
       
        public static DataTable GetAllUsers()
        {
           return clsDataUser.GetAllUsers();
        }

        private bool _AddNewUser()
        {
             UserID =  clsDataUser.AddNewPerson(PersonID, UserName, Password, IsActive);
            
            return UserID != -1;
        }

        public static clsUsers FindUserById(int UserID)
        {
            string userName = "", isActive = "";
           
              if(clsDataUser.GetUserDetails(UserID, ref userName, ref isActive))
                {
                    return new clsUsers(UserID, userName, isActive,-1);
                }
              else
                return null;

        }

        public static clsUsers GetUserIdAndPersonIdByUserName(string UserName)
        {
            int personId = -1,userId = -1;

            if (clsDataUser.GetUserDetailsByUserName(UserName, ref userId, ref personId))
            {
                return new clsUsers(userId, UserName, "", personId);
            }
            else
                return null;

        }

        public static int GetUserIdByUserName(string userName)
        {
            return clsDataUser.GetUserId(userName);
        }

        public static int GetPersonIdByUserName(string userName)
        {
            return clsDataUser.GetPersonID(userName);
        }

        public static bool isUserExist(int personID)
        {
            if(clsDataUser.IsUserExist(personID))
                return true;
            else 
                return false;
        }

        public static bool DeleteUser(int UserId)
        {
            if(clsDataUser.DeleteUser(UserId))
                return true;
            else return false;
        }

        public bool UpdateUser()
        {
            if(clsDataUser.UpdateUser(UserID, UserName, Password, IsActive))
                return true;
            else 
                return 
                    false;
            
        }

        public bool Save()
        {
            switch (Mode) 
            {
                case _enMode.AddNewMode:
                    Mode = _enMode.UpdateMode;
                    if(_AddNewUser())
                    {
                        return true;
                    }else
                        return false;
                    
                case _enMode.UpdateMode:
                    if(UpdateUser())
                        
                    return true;
                    else
                      return false;
                default:
                    return false;
            }
        }

        public static string GetPassword(int UserID)
        {
            return clsDataUser.GetUserPassword(UserID);
        }

        public static string GetPassword(string UserName)
        {
            return clsDataUser.GetUserPasswordByUserName(UserName);
        }

        public static bool UpdatePassword(int UserID, string Password)
        {
            return clsDataUser.UpdatePassword(UserID, Password);
        }

        public static bool IsUserNameExist(string UserName) 
        {
            return clsDataUser.IsUserNameExist(UserName);
        }
        public static string IsUserActive(string userName)
        {
            return clsDataUser.IsUserActive(userName);
        }
    }
}
