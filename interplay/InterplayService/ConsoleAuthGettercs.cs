using InterplayService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplayService
{
    public class ConsoleAuthGetters : ICredentialGetter
    {
        public Credential GetCredentials()
        {
            Credential credential = new Credential();
            Console.WriteLine("Enter User Name:");
            credential.UserName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            credential.Password = Console.ReadLine();

            return credential;
        }
    }
}
