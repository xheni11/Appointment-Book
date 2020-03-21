namespace AppointmentBook_Exercise7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REMINDER")]
    public partial class REMINDER
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdAppointment { get; set; }

        public int ReminderTime { get; set; }

        public int Snooze { get; set; }

        public bool HasSound { get; set; }
    }
}
