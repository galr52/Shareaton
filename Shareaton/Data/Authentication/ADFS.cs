using Shareaton.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;

namespace Shareaton.Data.Authentication
{
    public class ADFS
    {
        private static Dictionary<string, string> claims;
        private const string UNIQUE_ID = "http://sso/claims/UniqueID";
        private const string FIRST_NAME = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname";
        private const string LAST_NAME = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname";
        private const string HIRARCHY = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";

        public static User GetUser()
        {
            return new ADFS().GenerateUser();
        }

        private ADFS()
        {
            claims = new Dictionary<string, string>();
            ImportClaims();
        }

        private void ImportClaims()
        {
            // every claim in the claim collection is like property of object
            var claimColl = ((ClaimsIdentity)Thread.CurrentPrincipal.Identity).Claims;

            //Get the data if current user (MIV)
            foreach (Claim claim in claimColl)
            {
                var trimedClaim = claim?.Value?.Trim();

                if (claim.Type.Equals(UNIQUE_ID))
                {
                    claims.Add(UNIQUE_ID, trimedClaim);
                }
                else if (claim.Type.Equals(HIRARCHY))
                {
                    claims.Add(HIRARCHY, trimedClaim);
                }
                else if (claim.Type.Equals(FIRST_NAME))
                {
                    claims.Add(FIRST_NAME, trimedClaim);
                }
                else if (claim.Type.Equals(LAST_NAME))
                {
                    claims.Add(LAST_NAME, trimedClaim);
                }
            }
        }

        private string GetName()
        {
            return claims[FIRST_NAME] + " " + claims[LAST_NAME];
        }

        private string GetUniqueId()
        {
            return claims[UNIQUE_ID];
        }

        private string GetHirarchy()
        {
            return claims[HIRARCHY];
        }

        private User GenerateUser()
        {
            return new User
            {
                Hierarchy = GetHirarchy(),
                Name = GetName(),
                UniqueId = GetUniqueId()
            };
        }
    }
}