using Sol.Common;
using System;

namespace Sol.DTO
{
    public class EvaluationDTO : Int32EntityBase
    {
        public virtual InvoiceDTO Invoice { get; set; }

        public string User { get; set; }

        public DateTime EvaluationUtc { get; set; }

        public EvaluationStates State { get; set; }

        public string Notes { get; set; }
    }
}
