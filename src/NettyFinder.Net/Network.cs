﻿using System;
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

            if (Constants.starcomms.Contains(primaryPhonePrefix) || Constants.starcomms.Contains(secondaryPhonePrefix)) return Constants.Starcomms;
            if (Constants.multilinks.Contains(primaryPhonePrefix) || Constants.multilinks.Contains(secondaryPhonePrefix)) return Constants.Multilinks; 

            if (Constants.mtn.Contains(primaryPhonePrefix) || Constants.mtn.Contains(secondaryPhonePrefix)) return Constants.Mtn;
            if (Constants.glo.Contains(primaryPhonePrefix)) return Constants.Glo;
            if (Constants.airtel.Contains(primaryPhonePrefix)) return Constants.Airtel;
            if (Constants.etisalat.Contains(primaryPhonePrefix)) return Constants.EtisalatMobile;

         
            if (Constants.zoom.Contains(primaryPhonePrefix)) return Constants.Zoom;
            if (Constants.ntel.Contains(primaryPhonePrefix)) return Constants.Ntel;
            return Constants.smile.Contains(primaryPhonePrefix) ? Constants.Smile : null;
        }


        public string GetPhonePrefix(int length = 4)
        {
            return _phoneNumber.Substring(0, length);
        }

        public bool ValidatePhoneNumber()
        {
            var prefix = _phoneNumber.Substring(0,4);
            var phoneNumberEdited = _phoneNumber.StartsWith("+") ? _phoneNumber.Substring(1) : _phoneNumber;
            if (!phoneNumberEdited.All(c => char.IsDigit(c)))
            {
                throw new Exception("Phone number contains unwanted characters");
            }

            if(_phoneNumber.Length < 11)
            {
                throw new Exception("Phone number cannot be less than 11 digit.");
            }

            //Check if number without +234 is greater than 11
            if (_phoneNumber.Length > 11 && prefix != "+234")
            {
                throw new Exception("Number without +234 must not be greater than 11 digits");
            }

            // Check if +234 number is less than 14 characters
            if (_phoneNumber.Length < 14 && prefix == "+234")
            {
                throw new Exception("Number with +234 must be 14 characters long");
            }

            //Check if number with +234 is greater than 14 characters
            if (_phoneNumber.Length > 14 && prefix == "+234")
            {
                throw new Exception("Number with +234 must not be greater than 14 characters" );
            }

            //Convert it to normal 08030XXXXXXX
            if (prefix == "+234")
            {
                _phoneNumber = $"0{_phoneNumber.Substring(4)}";
            }

            return true;

        }

    }
}
