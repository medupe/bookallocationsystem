using System.Collections.Generic;

namespace bookallocationsystem.Models.Audits
{
    public class AuditViewIndex
    {
        public AuditViewIndex()
        {
            this.AuditList = new List<Audit>();
        }
        public List<Audit> AuditList { get; set; }
    }
}