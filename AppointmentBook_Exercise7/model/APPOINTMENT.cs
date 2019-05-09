namespace AppointmentBook_Exercise7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APPOINTMENT")]
    public partial class APPOINTMENT
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int IdScheduler { get; set; }

        public int IdLocation { get; set; }

        public byte Status { get; set; }

        public string Subject { get; set; }
    }
}
