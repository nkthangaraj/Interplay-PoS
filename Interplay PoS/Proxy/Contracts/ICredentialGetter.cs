using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.cloudloom.interplay.pos.Proxy.Contracts
{
   public interface ICredentialGetter
    {
        Credential GetCredentials();
    }
}
