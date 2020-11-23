using Model;
using System;
using static Service.DoctorService;

namespace Controller
{
   public class DoctorController
   {
        Service.DoctorService docService = new Service.DoctorService();
        
        public Model.Doctor LoginDoctor(String username, String password)
        {
            Doctor loggedDoctor = docService.LoginDoctor(username, password);
            return loggedDoctor;
        }
    }
}