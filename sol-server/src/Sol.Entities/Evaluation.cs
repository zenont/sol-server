using Sol.Common;
using System;

namespace Sol.Entities
{
    public class Evaluation: Int32EntityBase
    {
        public int InvoiceId { get; set; }

        public virtual Invoice Invoice { get; set; }

        public string User { get; set; }

        public DateTime EvaluationUtc { get; set; }

        public EvaluationStates State { get; set; }

        public string Notes { get; set; }
    }
}
