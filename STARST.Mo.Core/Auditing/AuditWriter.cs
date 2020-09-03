using STARST.Mo.Core.Auditing.Core;
using STARST.Mo.Core.Auditing.Repository;

namespace STARST.Mo.Core.Auditing
{
    /// <summary>
    /// Provides functionality to construct the Audit specific messages before write the entries into the data store.
    /// </summary>
    internal class AuditWriter : IAuditWriter
    {
        private IAuditRepository _auditRepository;

        public AuditWriter() : this(new AuditRepository())
        {
        }

        public AuditWriter(IAuditRepository auditRepository)
        {
            _auditRepository = auditRepository;
        }

        public void Wrtite(string message)
        {
            _auditRepository.Wrtite(message);
        }
    }
}
