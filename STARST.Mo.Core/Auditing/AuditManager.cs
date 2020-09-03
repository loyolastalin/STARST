using System;
using STARST.Mo.Core.Auditing.Core;

namespace STARST.Mo.Core.Auditing
{
    /// <summary>
    ///  Entry point to the Auditing system which provides functionality to write audit information
    /// </summary>
    public class AuditManager : IAuditManager
    {
        private static IAuditManager _instance = new AuditManager();
        private static IAuditWriter _auditWriter = new AuditWriter();

        public static IAuditManager Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Log(string message)
        {
            _auditWriter.Wrtite(message);
        }
    }
}
