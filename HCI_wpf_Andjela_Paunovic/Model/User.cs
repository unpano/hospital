using System;

namespace Model
{
   public class User : NotLoggedInUser
   {
        private int id;
        private String firstName;
        private String lastName;
        private String username;
        private String password;
        private String email;
        private long jmbg;
        private DateTime birthDateTime;
        private String address;
        private long phoneNumber;

        public int ID   // property
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName   // property
        {
            get { return firstName; }   
            set { firstName = value; }  
        }
        public string LastName   // property
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Username   // property
        {
            get { return username; }
            set { username = value; }
        }
        public string Password   // property
        {
            get { return password; }
            set { password = value; }
        }
        public string Email   // property
        {
            get { return email; }
            set { email = value; }
        }
        public long JMBG   // property
        {
            get { return jmbg; }
            set { jmbg = value; }
        }
        public DateTime BirthDateTime   // property
        {
            get { return birthDateTime; }
            set { birthDateTime = value; }
        }
        public string Address   // property
        {
            get { return address; }
            set { address = value; }
        }
        public long PhoneNumber   // property
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        
    }
}