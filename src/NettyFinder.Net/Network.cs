using System;
using System.Linq;

namespace NettyFinder.Net
{
    public class Network
    {
        private string _phoneNumber;

        public Network(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentException($"'{nameof(phoneNumber)}' cannot be null or empty.", nameof(phoneNumber));
            }
            _phoneNumber = phoneNumber;
        }

        public string GetNetworkName()
        {
            if(!ValidatePhoneNumber()) throw new Exception("Invalid phone number");

            var primaryPhonePrefix = GetPhonePrefix();
            var secondaryPhonePrefix = GetPhonePrefix(5);

            var prefixes = new[]{ primaryPhonePrefix, secondaryPhonePrefix };

            foreach (var prefix in prefixes)
            {
                if (Constants.MtnPrefixes.Contains(prefix)) return Constants.Mtn;
                if (Constants.GloPrefixes.Contains(prefix)) return Constants.Glo;
                if (Constants.AirtelPrefixes.Contains(prefix)) return Constants.Airtel;
                if (Constants.EtisalatPrefixes.Contains(prefix)) return Constants.EtisalatMobile; 
                if (Constants.ZoomPrefixes.Contains(prefix)) return Constants.Zoom;
                if (Constants.NtelPrefixes.Contains(prefix)) return Constants.Ntel;
                if (Constants.SmilePrefixes.Contains(prefix)) return Constants.Smile;
            }
            return  null;
        }


        public string GetPhonePrefix(int length = 4)
        {
            return _phoneNumber.Substring(0, length);
        }
        
        
        public bool ValidatePhoneNumber()
        {
            if (string.IsNullOrWhiteSpace(_phoneNumber))
                throw new Exception("Phone number cannot be empty.");

            var phone = _phoneNumber.Trim();

            // Normalize +234 → 0 and handle the check
            if (phone.StartsWith("+234"))
            {
                if (phone.Length != 14)
                    throw new Exception("Number with +234 must be 14 characters long.");

                phone = "0" + phone.Substring(4); // Convert +234xxxxxxxxxx → 0xxxxxxxxxx
            }
            else if (phone.StartsWith("234"))
            {
                if (phone.Length != 13)
                    throw new Exception("Number with 234 must be 13 characters long.");

                phone = "0" + phone.Substring(3); // Convert 234xxxxxxxxxx → 0xxxxxxxxxx
            }

            // Remove any '+' for further checks
            var phoneNumberEdited = phone.StartsWith("+") ? phone.Substring(1) : phone;

            if (!phoneNumberEdited.All(char.IsDigit))
                throw new Exception("Phone number contains invalid characters.");

            if (phone.Length < 11)
                throw new Exception("Phone number cannot be less than 11 digits.");

            if (phone.Length > 11)
                throw new Exception("Phone number must not be greater than 11 digits.");

            _phoneNumber = phone; // Normalize instance variable to 080x... format
            return true;
        }
        

    }
}
