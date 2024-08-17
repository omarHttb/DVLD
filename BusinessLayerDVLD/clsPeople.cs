using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsPeople
    {
        public enum enMode { addNew = 0, update = 1 }
        public  enMode Mode = enMode.addNew;

        public int ID { get; set; } 
        public string NationalNo { get; set; }
        public string FirstName { get; set; } = "";
        public string SecondName { get; set; }
        public string ThirdName { get; set; }   
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; } 
        public int NationalityCountryId { get; set; }
        public string ImagePath { get; set; }   


        

        public static DataTable GetAllPeople()
        
        {

            return clsDataPeople.GetAllPeople();
        }

        public clsPeople(int id, string NationalNo, string firstName, string secondName, string thirdName, string lastName
                  , DateTime dateOfBirth, int gender, string email, string phone, string address,
            int nationalityCountryId,
            string imagePath)
        {
            ID = id;
            this.NationalNo = NationalNo;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ThirdName = thirdName;
            this.SecondName = secondName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.NationalityCountryId = nationalityCountryId;
            this.ImagePath = imagePath;


            Mode = enMode.update;

        }

        public clsPeople()
        {
             this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.ImagePath = "";
            this.DateOfBirth = DateTime.MinValue;
            this.Gender = -1;
            this.NationalNo = "";
            this.NationalityCountryId = -1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
        }

        private  bool _AddNewPerson()
        {
            ID =  clsDataPeople.AddNewPerson(NationalNo
                , FirstName, SecondName, ThirdName,  LastName, 
                DateOfBirth, 
                Gender,
                Address, Phone, Email,
                NationalityCountryId,
                ImagePath);
            return (ID != -1);

        }

        public static bool _AddNewPerson(string nationalNo, string firstName, string secondName, string ThirdName,
            string lastName, DateTime DateOfBirth, short Gender, string address, string phone, string email, short nationalityCountryId
            , string image)
        {
            int ID = clsDataPeople.AddNewPerson(nationalNo
                 , firstName, secondName, ThirdName, lastName,
                 DateOfBirth,
                 Gender,
                 address, phone, email,
                 nationalityCountryId,
                 image);
            return (ID != -1);

        }
        public static clsPeople FindPersonById(int ID)
        {

            string FirstName = "", SecondName= "",ThirdName= "",LastName = "", Email = "", Phone = "", Address = "", ImagePath = "",NationalNo = "";
            DateTime DateOfBirth = DateTime.Now;
            int nationalityCountryId = -1,gender = -1;

            
            if (clsDataPeople.GetPersonByID(ref ID,ref NationalNo,ref FirstName,ref SecondName,ref ThirdName,ref LastName,ref DateOfBirth,ref gender,ref Address,ref Phone,
                ref Email,ref nationalityCountryId,ref ImagePath))

                return new clsPeople(ID,NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,gender,Email,Phone,Address,nationalityCountryId,
                    ImagePath);
            else
                return null;

        }

        public static clsPeople FindPersonByNationalNumber(string NationalNo)
        {

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int nationalityCountryId = -1, gender = -1 ,ID = -1;

            if (clsDataPeople.GetPersonByNationalNo(ref ID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref gender, ref Address, ref Phone,
                ref Email, ref nationalityCountryId, ref ImagePath))

                return new clsPeople(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, gender, Email, Phone, Address, nationalityCountryId,
                    ImagePath);
            else
                return null;

        }



        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsDataPeople.UpdatePerson(this.ID, NationalNo, FirstName, SecondName, ThirdName, LastName
                , DateOfBirth, Gender, Address, Phone, Email, NationalityCountryId, ImagePath);
        }

        public  bool save()
        {
            switch (Mode)
            {
                case enMode.addNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.update:
                    return _UpdatePerson();

            }
            return false;
        }

        public static bool IsNationalNoFound(string NationalNo)
        {
            if(clsDataPeople.IsNationalNoFound(NationalNo)) 
                return true;
            else
                return false;

        }
        
        public static bool IsPersonIDFound(string PersonID)
        {
            if (clsDataPeople.IsPersonIDFound(PersonID))
                return true;
            else
                return false;

        }

        public static bool DeletePerson(int ID)
        {
            if(clsDataPeople.DeleteContact(ID))
            {
                return true;
            }
            else
            {
                return false ;
            }
            
        }

        


    }
}
