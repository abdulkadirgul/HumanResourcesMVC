using Project.BLL.SingletonPatterns;
using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace WebUI.Attiributes
{
    public class AppUserRoleProvider : RoleProvider
    {
        AppDbContext db = Singleton.Context;
        public override string ApplicationName { get ; set ; }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            var userRoleList = from user in db.AppUsers
                               join userandrole in db.AppUserAndRoles on user.ID equals userandrole.AppUserID
                               join role in db.Roles on userandrole.AppUserRoleID equals role.ID
                               where user.UserName == username
                               select role.Role;

            return userRoleList.ToArray();
            
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}