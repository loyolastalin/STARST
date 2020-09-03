using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STARST.Mo.Core.Auditing.Core
{
    /// <summary>
    /// Interface for IAuditWriter
    /// </summary>
    public interface IAuditWriter
    {
        void Wrtite(string message);
    }
}
