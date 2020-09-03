using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STARST.Mo.Core.Auditing.Core
{
    /// <summary>
    /// Interface for IAuditRepository class to write audit entries
    /// </summary>
    public interface IAuditRepository
    {
        void Wrtite(string message);
    }
}
