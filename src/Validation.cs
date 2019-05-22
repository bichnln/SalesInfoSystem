using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SIS
{
    public static class Validation
    {
        public static string EmptyCheck( string text, string tbName )
        {
            if (String.IsNullOrWhiteSpace( text ))
            {
                return tbName + " is empty!\n";
            }
            else return "";
        }
        public static string EmailCheck( string email )
        {
            if (!(String.IsNullOrWhiteSpace( email )) && !(IsValidEmail( email )))
            {
                return "Email is invalid!\n";
            }
            else return "";
        }
        public static string PhoneNumberCheck( string phoneNumber )
        {
            if (!(String.IsNullOrWhiteSpace( phoneNumber )) && !(IsValidPhoneNumber( phoneNumber )))
            {
                return "Phone Number is invalid!\n";
            }
            else return "";
        }
        public static bool IsValidEmail( string email )
        {
            /*try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }*/
            Regex emailPattern = new Regex( @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$" );
            if (emailPattern.IsMatch( email ))
            {
                return true;
            }
            else return false;
        }
        public static bool IsValidPhoneNumber( string number )
        {
            Regex pattern1 = new Regex( @"^[\+]{1}[0-9]{2}[\ ]{1}[0]{1}[1-9]{9}$" );
            Regex pattern2 = new Regex( @"^[\+]{1}[0-9]{2}[\ ]{1}[1-9]{9}$" );
            Regex pattern3 = new Regex( @"[0]{1}[0-9]{9}" );
            if ((pattern1.IsMatch( number )) || (pattern2.IsMatch( number )) || (pattern3.IsMatch( number )))
            {
                return true;
            }
            else return false;
        }
    }
}
