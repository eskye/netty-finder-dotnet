using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NettyFinder.Net
{
    public static class Constants
    {
        //PHONE NUMBER PREFIX
        public const string Prefix = "+234";

        //ALL NETWORK PROVIDER NAME
        public const string Mtn = nameof(Mtn);
        public const string Glo = nameof(Glo);
        public const string EtisalatMobile = "9mobile";
        public const string Airtel = nameof(Airtel);
        public const string Starcomms = nameof(Starcomms); 
        public const string Multilinks = nameof(Multilinks);
        public const string Zoom = nameof(Zoom);
        public const string Ntel = nameof(Ntel);
        public const string Smile = nameof(Smile);

        //PHONE NUMBERS PREFIX FOR EACH NETWORK PROVIDER
        public static readonly string[] mtn = { "0806", "0803", "0816", "0813", "0810", "0814", "0903", "0906", "0703", "0706","0916","0913","07025", "07026","0704"};
        public static readonly string[] glo = { "0805", "0705", "0905", "0807", "0815", "0811", "0915" };
        public static readonly string[] airtel = { "0802", "0902", "0701", "0808", "0708", "0812", "0907", "0904", "0901", "0912" };
        public static readonly string[] etisalat = { "0809", "0909", "0817", "0818", "0908" };
        public static readonly string[] starcomms = { "07028", "07029", "0819" }; 
        public static readonly string[] multilinks = { "07027", "0709" };
        public static readonly string[] zoom = { "0707" };
        public static readonly string[] ntel = { "0804" };
        public static readonly string[] smile = { "0702" }; 
    }
}
