using ProxyUserContract = Proxy.Contracts.User;
using Proxy.Services;
using Proxy.Contracts;
using BusinessUserContract = BL.Contracts.User;
using System.Collections.Generic;

namespace BL
{
    public class UserBL
    {
        UserService userService;

        public UserBL(Credential credential)
        {
            userService = new UserService(credential);
        }

        public bool Authenticate(Credential credential)
        {
            ProxyUserContract.User user =  userService.GetProfile(credential);

            if (user == null)
                return false;
            else
                return true;
        }

        public List<BusinessUserContract.User> GetAllUsers()
        {
            List<ProxyUserContract.User> proxyContractUsers = this.userService.GetAllUsers();
            List<BusinessUserContract.User> businessUsers = this.ConvertToBusiness(proxyContractUsers);
            return businessUsers;
        }

        #region Converters
        private List<BusinessUserContract.User> ConvertToBusiness(List<ProxyUserContract.User> users)
        {
            List<BusinessUserContract.User> businessUsers = new List<BusinessUserContract.User>();

            users.ForEach(user => 
            {
                businessUsers.Add(new BusinessUserContract.User {username = user.username });
            });

            return businessUsers;
        }

        private List<ProxyUserContract.User> ConvertToProxy(List<BusinessUserContract.User> users)
        {
            return new List<ProxyUserContract.User>();
        }
        #endregion


    }
}
