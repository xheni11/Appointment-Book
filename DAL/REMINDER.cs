//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
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
