using System.Collections.Generic;
using IdentityServer4.Models;

namespace IdSrvDeploymentApp.Config
{
    public static class IdentityServerConfig
    {
        public static IList<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email()
            };
        }

        public static IList<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api", "API")
                {
                    Scopes = {"api"}
                }
            };
        }

        public static IList<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("api", "Access to the API.")
            };
        }

        /// <summary>
        /// Gets the clients from the JSON config file.
        /// </summary>
        /// <returns>The API clients.</returns>
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>();
        }
    }
}
