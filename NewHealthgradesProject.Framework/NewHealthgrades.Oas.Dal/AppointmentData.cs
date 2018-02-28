using NewHealthgrades.Oas.Dal.Interface;
using NewHealthgrades.Oas.Dal.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHealthgrades.Oas.Dal
{
    public class AppointmentData : IAppointmentData
    {
        NewDBAppointmentEntities db = new NewDBAppointmentEntities();
        
        //Get Method
        public AppointmentTBL GetAppointmentById(int appointmentId)
        {
           
            return db.AppointmentTBLs.Where(x => x.AppointmentId == appointmentId).SingleOrDefault();
           
        }

        //Post Method
        public string InsertAppointment(int appointmentId,int appointmentTypeId,string consumerId,string statusCode,string consumerName)
        {
            
            var appointment1 = new AppointmentTBL
            {
                AppointmentId = appointmentId,
                AppointmentTypeId = appointmentTypeId,
                ConsumerId = consumerId,
                StatusCode = statusCode,
                ConsumerName = consumerName
            };
           
            if (db.AppointmentTBLs.Any(c=>c.ConsumerName.Equals(consumerName)))//db.AppointmentTBLs.SingleOrDefault(c => c.ConsumerName == consumerName))
            {
                return "Already Exist";
               
            }
            else {
                 db.AppointmentTBLs.Add(appointment1);
                db.SaveChanges();
                return "Success";
            }
        }
        //Put Method
        public string UpdateAppointment(int appointmentId, int appointmentTypeId, string consumerId, string statusCode, string consumerName)
        {
           
                var selectedAppointment = db.AppointmentTBLs.FirstOrDefault(x => x.AppointmentId == appointmentId);
            if(selectedAppointment == null)
            {
                return "No Such AppointmentId Exist";
            }
            selectedAppointment.AppointmentTypeId = appointmentTypeId;
            selectedAppointment.ConsumerId = consumerId;
            selectedAppointment.ConsumerName = consumerName;
            selectedAppointment.StatusCode = statusCode;

            db.SaveChanges();
            return "Updated Successfully";
            
        }
        //Delete Appointment
        public string DeleteAppointment(int appointmentId )
        {
                var deleteAppointment = db.AppointmentTBLs.FirstOrDefault(x => x.AppointmentId == appointmentId);
            if (deleteAppointment == null)
            {
                return "No Such AppointmentId Exist";
            }
            db.AppointmentTBLs.Remove(deleteAppointment);
            db.SaveChanges();
            return "Deleted Successfully";
        }
    }
}
