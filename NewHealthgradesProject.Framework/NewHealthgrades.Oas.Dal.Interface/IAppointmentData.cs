using NewHealthgrades.Oas.Dal.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHealthgrades.Oas.Dal.Interface
{
    public interface IAppointmentData
    {
        AppointmentTBL GetAppointmentById(int appointmentId);
        string InsertAppointment(int appointmentId, int appointmentTypeId, string consumerId, string statusCode, string consumerName);
        
        string UpdateAppointment(int appointmentId, int appointmentTypeId, string consumerId, string statusCode, string consumerName);
        string DeleteAppointment(int appointmentId);
    }
}
