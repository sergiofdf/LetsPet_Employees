using System.Text.RegularExpressions;
namespace LetsPet_Employees
{
    public static class Validation
    {
        public static bool IsZipCodeValid(string zipCode)
        {
            Regex RgxZipCode = new(@"^\d{5}-\d{3}$");
            if (!RgxZipCode.Match(zipCode).Success)
            {
                Console.WriteLine("Cep digitado inválido!\nDigite o CEP no formato xxxxx-xxx");
                return false;
            }
            return true;
        }
        public static bool IsPhoneValid(string phone)
        {
            Regex RgxPhone = new(@"^\(?\d{2}\)?\d{4,5}-?\d{4}$");
            if (!RgxPhone.Match(phone).Success)
            {
                Console.WriteLine("Telefone digitado inválido!\nDigite no formato (12)12345-1234");
                return false;
            }
            return true;
        }
        public static bool IsCpfValid(string cpf)
        {
            Regex RgxCpf = new(@"^\d{3}\.?\d{3}\.?\d{3}-?\d{2}$");
            if (!RgxCpf.Match(cpf).Success)
            {
                Console.WriteLine("Cpf digitado inválido!\nDigite no formato 123.123.123-12");
                return false;
            }
            return true;
        }

        public static bool IsEmailValid(string email)
        {
            Regex RgxEmail = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if(!RgxEmail.Match(email).Success)
            {
                Console.WriteLine("Email digitado inválido! \nDigite no formato abcd@abcd.com ");
                return false;
            }
            return true;
        }

        public static bool IsRandomKeyValid(string randomKey)
        {
            Regex RgxRandKey = new(@"^(\w+${8})\-(\w+${4})\-(\w+${4})\-(\w+${4})\-(\w+${12})");
            if (!RgxRandKey.Match(randomKey).Success)
            {
                Console.WriteLine("Chave aleatóroa inválida! \nDigiget no formato ********-****-****-****-************");
                return false;
            }
            return true;
        }


       
    }
}
