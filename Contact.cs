namespace LetsPet_Employees
{
    public class Contact
    {
        private string Street { get; set; }
        private int Number { get; set; }
        private string AdditionalAdressInfo { get; set; }
        private string District { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string ZipCode { get; set; }
        private string Phone { get; set; }
        private string MobileNumber { get; set; }
        private string Email { get; set; }

        public Contact()
        {
            Contact NovoContato = RegisterContact();

            Street = NovoContato.Street;
            Number = NovoContato.Number;
            AdditionalAdressInfo = NovoContato.AdditionalAdressInfo;
            District = NovoContato.District;
            City = NovoContato.City;
            State = NovoContato.State;
            ZipCode = NovoContato.ZipCode;
            Phone = NovoContato.Phone;
            MobileNumber = NovoContato.MobileNumber;
            Email = NovoContato.Email;
        }

        public Contact(string street, int number, string district,
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
        public void UpdateAdress(string street, int number, string district,
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
        public Contact RegisterContact()
        {
            string street, district, city, state, zipcode, mobileNumber, email, phone, addInfo;
            int number;

            Header();
            street = Validation.ValidateStringInput("Informe o nome da rua/avenida:", "O nome da Rua/Avenia é inválido.");

            Header();
            number = Validation.ValidatePositiveIntInput("Informe o número:", "O numero informado é inválido.");

            Header();
            district = Validation.ValidateStringInput("Informe o nome do bairro:", "O nome do bairro é inválido.");

            Header();
            city = Validation.ValidateStringInput("Informe o nome da cidade:", "O nome da cidade é inválida.");

            Header();
            state = Validation.ValidateStringInput("Informe o nome do estado:", "O nome do estado é inválido.");

            Header();
            zipcode = Validation.ValidateZipCodeInput("Informe o CEP");

            Header();
            mobileNumber = Validation.ValidatePhoneInput("Informe o numero de telefone:");

            Header();
            email = Validation.ValidadeEmailInput("Informe o email:");

            Header();
            if (OptionalInfos("Possuiu telefone fixo?"))
            {
                phone = mobileNumber = Validation.ValidatePhoneInput("Informe o numero de telefone fixo:");
            }
            else
                phone = "";

            Header();
            if (OptionalInfos("Alguma informamação adicional?"))
            {
                addInfo = Validation.ValidateStringInput("Descreva a observação:", "O campo de observação está em branco.");
            }
            else
                addInfo = "";


            return new Contact(street, number, district, city, state, zipcode, mobileNumber, email, phone, addInfo);
        }
        private void Header()
        {
            Console.Clear();
            Console.WriteLine("------- CADASTRO DE CONTATO -------");
        }
        private bool OptionalInfos(string question, string ErrorMessage = "Input inválido.")
        {
            string response, options = "(S/N)";
            bool validation;
            do
            {
                Console.WriteLine($"{question} {options}");
                response = Console.ReadLine();
                validation = response != "S" && response != "N" || string.IsNullOrWhiteSpace(response);
                if (validation)
                {
                    Console.WriteLine(ErrorMessage);
                }
            } while (validation);

            if (response == "S") return true;

            return false;
        }
    }
}
