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
            else 
            {
               
                if (text.Length < 3)
                {
                    return tbName + " is to short to have meaning!";
                }
                else
                {
                    return "";
                }
            }
        }

        private static bool IsValidPhoneNumber( string number )
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
       
        public static string PhoneNumberCheck( string phoneNumber )
        {
            if (!(String.IsNullOrWhiteSpace( phoneNumber )) && !(IsValidPhoneNumber( phoneNumber )))
            {
                return "Phone Number is invalid!\n";
            }
            else return "";
        }
        public static string PriceCheck(string price, string tbName)
        {
            double number; 

            if (String.IsNullOrEmpty(price))
            {
                return tbName + " is empty!";
            }
            else
            {
                if (Double.TryParse(price, out number) && number>= 0 )
                {
                    return "";
                }
                else
                {
                    return tbName + " is invalid!\n";
                }
            }
        }
        public static string YearCheck(string year)
        {
            int number;

            if (String.IsNullOrEmpty(year))
            {
                return "Year is empty!\n";
            }
            else
            {
                if (Int32.TryParse(year, out number) && ((number > 1900) && (number <= 2019)))
                {
                    return "";
                }
                else
                {
                    return "Year is invalid!\n";
                }
            }
        }

        
    }
}
