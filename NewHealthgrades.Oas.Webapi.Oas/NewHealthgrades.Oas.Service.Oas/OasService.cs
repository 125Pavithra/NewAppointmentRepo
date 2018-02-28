

using NewHealthgrades.Oas.Dal;
using NewHealthgrades.Oas.Dal.Interface;
using NewHealthgrades.Oas.Dal.Sql;
using NewHealthgrades.Oas.Service.Oas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHealthgrades.Oas.Service.Oas
{
   public class OasService : IOasService 
    {
        private readonly IAppointmentData _appointmentData;
        //constructor
        public OasService(IAppointmentData appointmentData)
        {
            _appointmentData = appointmentData;
        }
        public OasService() { }

        //Get Method
        public AppointmentTBL GetAppointmentById(int appointmentId)
        {
            var appointment1 = _appointmentData.GetAppointmentById(appointmentId);
            return appointment1;
        }

        //Post Method
        public string InsertNewAppointment( AppointmentTBL app)
        {
            var appointment = _appointmentData.InsertAppointment(app.AppointmentId, app.AppointmentTypeId,app.ConsumerId,app.StatusCode,app.ConsumerName );
            return appointment;
        }
        //Put Method

        public string UpdateOldAppointment(AppointmentTBL app)

        {
            var appointment3 = _appointmentData.UpdateAppointment(app.AppointmentId, app.AppointmentTypeId, app.ConsumerId, app.StatusCode, app.ConsumerName);
            return appointment3;

        }

        //Delete Method

        public string DeleteAppointmentById(int id)

        {
            var appointment2 = _appointmentData.DeleteAppointment(id);
            return appointment2;
        }
    }
}
