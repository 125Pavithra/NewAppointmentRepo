using NewHealthgrades.Oas.Dal;
using NewHealthgrades.Oas.Dal.Interface;
using NewHealthgrades.Oas.Dal.Sql;
using NewHealthgrades.Oas.Service.Oas;
using NewHealthgrades.Oas.Service.Oas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NewHealthgrades.Oas.Webapi.Oas.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AppointmentController : ApiController
    {
        private readonly IOasService _oasService;
        private readonly IAppointmentData _appointmentData;
        public AppointmentController()
        {
            _appointmentData = new AppointmentData();
            _oasService = new OasService(_appointmentData);
        }
    
        [HttpGet]
      
        public AppointmentTBL GetAppointment(int id)
        {
            var response1 =  _oasService.GetAppointmentById(id);
            return response1;
        }

        [HttpPost]
     //inserting New appointment -Pavi
        public string InsertAppointment(AppointmentTBL app )
        {
            var response = _oasService.InsertNewAppointment(app);
            return response;
        }
        [HttpPut]
      
        public string UpdateAppointment(AppointmentTBL app)
        {
            var response =  _oasService.UpdateOldAppointment(app);
            return response;
        }
        [HttpDelete]
        //Delete an appointment from the database by giving the appointmentid

        public string DeleteAppointment(int id)
        {
            var response2 = _oasService.DeleteAppointmentById(id);
            return response2;
        }
    }
}
