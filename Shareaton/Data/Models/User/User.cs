using Shareaton.Data.Authentication;
using Shareaton.Data.DAL.SqlServer;
using Shareaton.Data.UserOperations;
using System;
using System.Collections.Generic;
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
        public DateTime Last_Seen { get; set; }
        // Lazy laoding
        public virtual Folder Root_Folder { get; set; }
        public virtual List<Node> Shared_Nodes { get; set; }
        public virtual List<Node> Groups { get; set; }

        internal static User GetCurrentUser()
        {
            User adfsUser = ADFS.GetUser();
            User currentUser = null;

            using (UserRepository userRepository = new UserRepository())
            {
                currentUser = userRepository.FindBy(x => x.UniqueId.ToLower().Equals(adfsUser.UniqueId.ToLower())).FirstOrDefault();
            }

            if (currentUser == null)
                currentUser = UserGenerator.GenerateNewUser(adfsUser);

            return currentUser;
        }
    }
}