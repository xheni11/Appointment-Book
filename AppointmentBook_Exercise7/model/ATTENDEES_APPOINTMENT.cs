namespace AppointmentBook_Exercise7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ATTENDEES_APPOINTMENT
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdAppointment { get; set; }

        public bool Accepted { get; set; }

        public bool HasReminder { get; set; }

        public string Note { get; set; }
    }
}
