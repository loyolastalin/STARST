using System;

namespace STARST.Mo.Core.Auditing.Core
{
    /// <summary>
    /// Interface to provide Audit logging functionality
    /// </summary>
    public interface IAuditManager
    {
        void Log(string message);
    }
}
