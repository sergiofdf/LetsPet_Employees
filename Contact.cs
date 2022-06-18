namespace LetsPet_Employees
{
    public class Contact
    {
        private string Street { get; set; }
        private string Number { get; set; }
        private string AdditionalAdressInfo { get; set; }
        private string District { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string ZipCode { get; set; }
        private string Phone { get; set; }
        private string MobileNumber { get; set; }
        private string Email { get; set; }

        //public Contact(string street, string number, string district,
        //    string city, string state, string zipcode,
        //    string mobileNumber, string email,
        //    string phone = "", string addInfo = "")
        //{
        //    Street = street;
        //    Number = number;
        //    AdditionalAdressInfo = addInfo;
        //    District = district;
        //    City = city;
        //    State = state;
        //    ZipCode = zipcode;
        //    Ddd = ddd;
        //    Phone = phone;
        //    DddMobile = dddMobile;
        //    MobileNumber = mobileNumber;
        //    Email = email;
        //}
        public void UpdateAdress(string street, string number, string district,
            string city, string state, string zipcode,
            string mobileNumber, string email,
            string phone = "", string addInfo = "")
        {
            Street = street;
            Number = number;
            AdditionalAdressInfo = addInfo;
            District = district;
            City = city;
            State = state;
            ZipCode = zipcode;
            Phone = phone;
            MobileNumber = mobileNumber;
            Email = email;
        }

    }
}
