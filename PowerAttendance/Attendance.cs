namespace PowerAttendance
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendance")]
    public partial class Attendance
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AttendanceDate { get; set; }

        public virtual Member Member { get; set; }
    }
}
