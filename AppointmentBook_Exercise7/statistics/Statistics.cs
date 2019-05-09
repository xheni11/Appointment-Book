using AppointmentBook_Exercise7.dataAccess;
using AppointmentBook_Exercise7.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBook_Exercise7.statistics
{
    public class Statistics
    {

        //AppointmentService appointmentService = new AppointmentService();
        //List<Appointment> appointments = new List<Appointment>();
        public List<AppointmentData> Longest_User_Appointment(int id )
        {
            int maxDurationTime;
            AppointmentContext context = new AppointmentContext();
            List<AppointmentData> appointmentDatas = new List<AppointmentData>();
            Repository<LOCATION> repository = new Repository<LOCATION>(context);
            var listAppointmentUser = repository.GetAllAppointmentUser(id);
            maxDurationTime = listAppointmentUser.Select(list => (list.EndDate - list.StartDate).Milliseconds).Max();
            appointmentDatas.AddRange(listAppointmentUser.Where(list => (list.EndDate - list.StartDate).Milliseconds == maxDurationTime));

            return appointmentDatas;
        }
        public List<AppointmentData> Earliest_Appointment_Of_User(int id)
        {
            int dateStart;
            AppointmentContext context = new AppointmentContext();
            List<AppointmentData> appointmentDatas = new List<AppointmentData>();
            Repository<LOCATION> repository = new Repository<LOCATION>(context);
            var listAppointmentUser = repository.GetAllAppointmentUser(id);

            dateStart = listAppointmentUser.Select(list => list.StartDate.Day * 60 * 24 + list.StartDate.Hour * 60 + list.StartDate.Minute).Min();
            appointmentDatas.AddRange(listAppointmentUser.Where(list => (list.StartDate.Day * 60 * 24 + list.StartDate.Hour * 60 + list.StartDate.Minute) == dateStart));

            return appointmentDatas;
        }
        //public int Appointments_Number_For_User(int id)
        //{
        //    AppointmentContext context = new AppointmentContext();
        //    List<AppointmentData> appointmentDatas = new List<AppointmentData>();
        //    Repository<LOCATION> repository = new Repository<LOCATION>(context);
        //    var listAppointment = repository.GetAllAppointmentUser(id);
        //    var listGroup = listAppointment.GroupBy(list => list.Scheduler);
        //    return listAppointment.Count(l => l.Scheduler.Username == username);

        //}
        //public List<Appointment> Longest_Day_Appointment(DateTime date)
        //{
        //    int maxDurationTime;
        //    var listAppointment = appointmentService.GetAllAppointments().Where(app => app.StartDate.Day == date.Day);
        //    maxDurationTime = listAppointment.Select(list => (list.EndDate - list.StartDate).Milliseconds).Max();
        //    appointments.AddRange(listAppointment.Where(list => (list.EndDate - list.StartDate).Milliseconds == maxDurationTime));
        //    return appointments;
        //}
        //public List<Appointment> Earliest_Appointment_Of_Day(DateTime date)
        //{
        //    int dateStart;
        //    var listAppointment = appointmentService.GetAllAppointments().Where(app => app.StartDate.Day == date.Day);
        //    dateStart = listAppointment.Select(list => Convert.ToInt32(list.StartDate)).Min();
        //    appointments.AddRange(listAppointment.Where(list => Convert.ToInt32(list.StartDate) == dateStart));
        //    return appointments;
        //}
        //public int Appointments_Number_For_Day(DateTime date)
        //{
        //    var listAppointment = appointmentService.GetAllAppointments();

        //    return listAppointment.Count(l => l.StartDate.Date.Day == date.Day);
        //}
        //public List<Appointment> Largest_Number_Of_Attendees()
        //{
        //    int maxNumber;
        //    var listAppointment = appointmentService.GetAllAppointments();
        //    maxNumber = listAppointment.Select(list => list.Attendees.Count).Max();
        //    appointments.AddRange(listAppointment.Where(list => list.Attendees.Count == maxNumber));
        //    return appointments;
        //}
        //public double Average_Duration_Of_Appointments_Of_Day(DateTime date)
        //{

        //    var listAppointment = appointmentService.GetAllAppointments().Where(app => app.StartDate.Day == date.Day).Select(list => (
        //                              list.EndDate - list.StartDate).Minutes);

        //    return listAppointment.Average();
        //    //durationTime = listAppointment.GroupBy(list => list.StartDate.Date).Select(list => (list.EndDate - list.StartDate).Milliseconds).;
        //}

    }

}
