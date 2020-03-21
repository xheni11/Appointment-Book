using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBook_Exercise7.model
{
    public class AppointmentData
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public USER Scheduler;
        public LOCATION Location ;
        public string LocationName { get; set; }
        public string Subject { get; set; }
        public int Status { get; set; }
    }
}
