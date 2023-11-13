using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Utilities
    {
        public static bool IsValidEmail(string email)
        {
            bool result = false;

            var checkMail = new EmailAddressAttribute();
            result = checkMail.IsValid(email);

            return result;
        }
    }
}
