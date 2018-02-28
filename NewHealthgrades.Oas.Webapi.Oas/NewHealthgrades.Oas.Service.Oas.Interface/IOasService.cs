using NewHealthgrades.Oas.Dal.Interface;
using NewHealthgrades.Oas.Dal.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHealthgrades.Oas.Service.Oas.Interface
{
    public interface IOasService
    {
        
        AppointmentTBL GetAppointmentById(int appointmentId);
      
        string InsertNewAppointment(AppointmentTBL app);
        
        string DeleteAppointmentById(int id);
       
        string UpdateOldAppointment(AppointmentTBL app);
    }
}
