using AppointmentBook_Exercise7.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBook_Exercise7.dataAccess
{
    public class Repository<TEntity> where TEntity : class
    {
        internal AppointmentContext context;
        internal DbSet<TEntity> dbSet;
        public Repository(AppointmentContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
  
        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }
        public virtual List<USER> GetAllUsers()
        {

            return context.USERS.Where(u=>u.Id!=SessionContext.Instance.CurrentUser.Id).ToList();
        }

        public virtual List<LOCATION> GetAllLocations()
        {

            return context.LOCATIONs.ToList();
        }
        public virtual List<ATTENDEES_APPOINTMENT> GetAllAttendees()
        {

            return context.ATTENDEES_APPOINTMENT.ToList();
        }
        public virtual Stack<>
        public virtual ATTENDEES_APPOINTMENT GetAttende(int idAppointment,int idUser)
        {
            List<ATTENDEES_APPOINTMENT> attendees= context.ATTENDEES_APPOINTMENT.ToList();
            ATTENDEES_APPOINTMENT attendees_appointment = new ATTENDEES_APPOINTMENT();
            foreach(ATTENDEES_APPOINTMENT item in attendees)
            {
                if (item.IdAppointment == idAppointment && item.IdUser == idUser)
                    return item;
            }
            return attendees_appointment;
        }
        public virtual List<T> GetAllRoles()
        {

            return context.ROLEs.ToList();
        }
        public virtual List<AppointmentData> GetAllAppointment()
        {

            var appointment = (from a in context.APPOINTMENTs
                              join l in context.LOCATIONs
                              on a.IdLocation equals l.Id
                              join u in context.USERS
                              on a.IdScheduler equals u.Id
                      
                              select new AppointmentData
                              {
                                  Id=a.Id,
                                  StartDate= a.StartDate,
                                  EndDate= a.EndDate,
                                  Location= l,
                                  LocationName = l.Name,
                                  Scheduler = u,
                                  CreatedDate= a.CreatedDate,
                                  ModifiedDate= a.ModifiedDate,
                                  Status= a.Status ,
                                  Subject = a.Subject
                              }).ToList();
            
            return appointment;


        }
        public virtual List<AppointmentData> GetAllAppointmentUser(int id)
        {

            var appointment = (from a in context.APPOINTMENTs
                               join l in context.LOCATIONs
                               on a.IdLocation equals l.Id
                               join u in context.USERS
                               on a.IdScheduler equals u.Id
                               where a.IdScheduler==id && a.Status==1
                               select new AppointmentData
                               {
                                   Id=a.Id,
                                   StartDate = a.StartDate,
                                   EndDate = a.EndDate,
                                   Location = l,
                                   LocationName=l.Name,
                                   Scheduler = u,
                                   CreatedDate = a.CreatedDate,
                                   ModifiedDate = a.ModifiedDate,
                                   Status = a.Status,
                                   Subject=a.Subject
                               }).ToList();

            return appointment;


        }
        public virtual List<AppointmentData> GetAllInvitationUser(int id)
        {

            var appointment = (from a in context.APPOINTMENTs
                               join l in context.LOCATIONs
                               on a.IdLocation equals l.Id
                               join at in context.ATTENDEES_APPOINTMENT
                               on a.Id equals at.IdAppointment
                               where a.Status == 1 && at.IdUser == id && at.Accepted == false
                               select new AppointmentData
                               {
                                   Id = a.Id,
                                   StartDate = a.StartDate,
                                   EndDate = a.EndDate,
                                   Location = l,
                                   LocationName = l.Name,
                                   CreatedDate = a.CreatedDate,
                                   ModifiedDate = a.ModifiedDate,                                  
                                   Subject = a.Subject
                               }).ToList();

            return appointment;


        }
        public virtual List<AppointmentData> GetAllInvitationCanceled(int id)
        {

            var appointment = (from a in context.APPOINTMENTs
                               join l in context.LOCATIONs
                               on a.IdLocation equals l.Id
                               join at in context.ATTENDEES_APPOINTMENT
                               on a.Id equals at.IdAppointment
                               where a.Status == 0 && at.IdUser == id 
                               select new AppointmentData
                               {
                                   Id = a.Id,
                                   StartDate = a.StartDate,
                                   EndDate = a.EndDate,
                                   Location = l,
                                   LocationName = l.Name,
                                   CreatedDate = a.CreatedDate,
                                   ModifiedDate = a.ModifiedDate,
                                   Subject = a.Subject
                               }).ToList();

            return appointment;


        }
        public virtual USER GetByUsernameAndPassword(string username,string password)
        {
            return context.USERS.Where(u=>u.Username.Equals(username)&&u.Password.Equals(password)).SingleOrDefault();
        }
        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }
        public virtual void Delete(TEntity entityToDelete)
        {
            context.Entry(entityToDelete).State = EntityState.Deleted;
            context.SaveChanges();
   
        }
        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
