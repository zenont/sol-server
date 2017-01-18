using Sol.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol.DTO
{
    public class InvoiceDTO : Int32EntityBase
    {
        public int DeliveryPointId { get; set; }

        public DeliveryPointDTO DeliveryPoint { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int ZoneId { get; set; }

        public virtual ZoneDTO Zone { get; set; }

        public EvaluationStates EvaluationState { get; set; }

        public DateTime? LastEvaluation { get; set; }

        public string LastEvaluatedBy { get; set; }
    }
}
