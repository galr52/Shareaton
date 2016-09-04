using Shareaton.Data.DAL.SqlServer;
using Shareaton.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shareaton.Data.UserOperations
{
    public class UserGenerator
    {
        public static User GenerateNewUser(User adfsUser)
        {
            var rootFolder = new Folder
            {
                Name = "root",
                Creation = DateTime.Now,
                Location = adfsUser.UniqueId,
                Parent = null,
                Modify = DateTime.Now
            };

            User newUser = new User
            {
                Name = adfsUser.Name,
                UniqueId = adfsUser.UniqueId,
                Hierarchy = adfsUser.Hierarchy,
                Root_Folder = rootFolder
            };

            using (UserRepository userRepository = new UserRepository())
            {
                userRepository.Add(newUser);
            }
                return newUser;
        }
    }
}