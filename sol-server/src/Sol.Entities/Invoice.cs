using Sol.Common;
using System;

namespace Sol.Entities
{
    public class Invoice: Int32EntityBase
    {
        public string DeliveryPoint { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int ZoneId { get; set; }

        public virtual Zone Zone { get; set; }

        public EvaluationStates EvaluationState { get; set; }

        public DateTime? LastEvaluation { get; set; }

        public string LastEvaluatedBy { get; set; }
    }
}
