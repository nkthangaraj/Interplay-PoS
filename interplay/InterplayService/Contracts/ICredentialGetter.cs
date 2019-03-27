using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplayService.Contracts
{
   public interface ICredentialGetter
    {
        Credential GetCredentials();
    }
}
