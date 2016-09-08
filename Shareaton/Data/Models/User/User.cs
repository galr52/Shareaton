using Shareaton.Data.Authentication;
using Shareaton.Data.DAL.SqlServer;
using Shareaton.Data.UserOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Shareaton.Data.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Color { get; set; }
        public string UniqueId { get; set; }
        public string Hierarchy { get; set; }
        public virtual Usage Usage { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime Last_Seen { get; set; }
        // Lazy laoding
        public virtual Folder Root_Folder { get; set; }
        public virtual List<Group> Groups { get; set; }

        internal static User GetCurrentUser()
        {
            User adfsUser = ADFS.GetUser();
            User currentUser = null;

            using (UserRepository userRepository = new UserRepository())
            {
                currentUser = userRepository.FindBy(x => x.UniqueId.ToLower().Equals(adfsUser.UniqueId.ToLower())).FirstOrDefault();

                if (currentUser == null)
                {
                    currentUser = UserGenerator.GenerateNewUser(adfsUser);
                }
                else if (ShouldUpdate(adfsUser, currentUser))
                {
                    Update(adfsUser, currentUser, userRepository);
                }
            }

            return currentUser;
        }

        private static void Update(User adfsUser, User currentUser, UserRepository userRepository)
        {
            currentUser.Name = adfsUser.Name;
            currentUser.Hierarchy = adfsUser.Hierarchy;
            userRepository.Edit(currentUser);
        }

        private static bool ShouldUpdate(User adfsUser, User currentUser)
        {
            return ShouldUpdateName(adfsUser, currentUser) || ShouldUpdateHierarchy(adfsUser, currentUser);
        }

        private static bool ShouldUpdateName(User adfsUser, User currentUser)
        {
            return (currentUser.Name.ToLower() != adfsUser.Name.ToLower());
        }

        private static bool ShouldUpdateHierarchy(User adfsUser, User currentUser)
        {
            return (currentUser.Hierarchy.ToLower() != adfsUser.Hierarchy.ToLower());
        }
    }
}