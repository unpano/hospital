using Model;
using Repository;
using System;
using static Repository.DoctorRepository;

namespace Service
{
   public class DoctorService
   {
        DoctorRepository docRepository = new DoctorRepository();

        public Model.Doctor LoginDoctor(String username, String password)
        {
            Doctor valCred = docRepository.findOneByUsernameAndPassword(username, password);
            if (valCred == null) return null; else return valCred;
            
        }
    }
}