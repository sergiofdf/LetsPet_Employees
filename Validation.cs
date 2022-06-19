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
    }
}
