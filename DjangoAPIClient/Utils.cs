using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DjangoAPIClient
{
    public static class Utils
    {
        public static bool OnlyNumbers(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
            //return Regex.IsMatch(input, @"^[^0-9]");
        }

        public static bool OnlyLettersWSpace(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-ZÁÉÍÓÚñáéíóúÑ ]*$");
            //return Regex.IsMatch(input, @"^[^0-9]");
        }

        public static bool OnlyLetters(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-ZÁÉÍÓÚñáéíóúÑ]*$");
            //return Regex.IsMatch(input, @"^[^0-9]");
        }

        public static bool OnlyEmailLetters(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9@.-_]*$");
            //return Regex.IsMatch(input, @"^[^0-9]");
        }

        public static bool OnlyNumbersAndLetters(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9]*$");
        }


        public static bool OnlySpecials(string input)
        {
            return Regex.IsMatch(input, @"\`|\~|\!|\@|\#|\$|\%|\^|\&|\*|\(|\)|\+|\=|\[|\{|\]|\}|\||\\|\'|\<|\,|\.|\>|\?|\/|\""|\;|\:|\s");
        }

        public static bool IsName(string input)
        {
           // return Regex.IsMatch(input, @"^([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\']+[\s])+([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\'])?$");
           // return Regex.IsMatch(input, @"^([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\']*$");
            //@"^(?:\s*[a-zA-Z]\s*){2,2}$"
            return true;
        }
        
        public static bool IsEmail(string input)
        {
            return Regex.IsMatch(input, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        public static bool IsPhone(string input)
        {
            //return Regex.IsMatch(input, @"^(('[\w-\s]+')|([\w-]+(?:\.[\w-]+)*)|('[\w -\s] + ')([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)");
            return true;
        }

        public static bool IsID(string input)
        {
            //return Regex.IsMatch(input, @"^(('[\w-\s]+')|([\w-]+(?:\.[\w-]+)*)|('[\w -\s] + ')([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)");
            return true;
        }

        public static bool IsDNI(string input)
        {
            //  return Regex.IsMatch(input, @"^(([A-Z])|\d)?\d{8}(\d|[A-Z])?$");         
            return true;
        }

        public static bool IsNIE(string input)
        {
            //return Regex.IsMatch(input, @"^(([A-Z])|\d)?\d{8}(\d|[A-Z])?$");
            return true;
        }
    }
}
