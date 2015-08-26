namespace PowerAttendance
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        public int Id { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PaymentDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public int? MemberId { get; set; }

        public virtual Member Member { get; set; }
    }
}
