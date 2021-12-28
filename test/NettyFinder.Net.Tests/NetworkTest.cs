using System;
using Xunit;
using Shouldly;
namespace NettyFinder.Net.Tests
{
    public class NetworkTest
    {
        private readonly string phoneNumber = "+2348034050677";

        [Fact]
        public void Network_Initialize_Should_Throw_Exception_With_Empty_Value()
        {
            _ = Should.Throw<ArgumentException>(() => new Network(string.Empty));

        }

        [Fact]
        public void Validate_PhoneNumber_Is_Not_Greater_Than_11_digit()
        {
           var network = new Network(phoneNumber);
           var result = network.ValidatePhoneNumber();
            result.ShouldBeTrue();
        }


        [Fact]
        public void Validate_PhoneNumber_Throw_Exception_If_Greater_Than_11_digit()
        {
            var network = new Network($"{phoneNumber}980");
            Should.Throw<Exception>(() => network.ValidatePhoneNumber());
        }

        [Fact]
        public void Return_The_Phone_Number_Prefix()
        {
            var network = new Network(phoneNumber);
            var prefix = network.GetPhonePrefix();
            prefix.Length.ShouldBe(4);
        }

        [Fact]
        public void Return_MTN_Network_Name()
        {
            var network = new Network(phoneNumber);
            var result = network.GetNetworkName();
            result.ShouldBe(Constants.Mtn);
        }

        [Fact]
        public void Return_Glo_Network_Name()
        {
            var network = new Network("+2347055679584");
            var result = network.GetNetworkName();
            result.ShouldBe(Constants.Glo);
        }

        [Fact]
        public void Return_Airtel_Network_Name()
        {
            var network = new Network("08021458945");
            var result = network.GetNetworkName();
            result.ShouldBe(Constants.Airtel);
        }

        [Fact]
        public void Return_Etisalat_Network_Name()
        {
            var network = new Network("08091458945");
            var result = network.GetNetworkName();
            result.ShouldBe(Constants.EtisalatMobile);
        }

        [Fact]
        public void Return_Ntel_Network_Name()
        {
            var network = new Network("08041458945");
            var result = network.GetNetworkName();
            result.ShouldBe(Constants.Ntel);
        }

        [Fact]
        public void Return_Zoom_Network_Name()
        {
            var network = new Network("07071458945");
            var result = network.GetNetworkName();
            result.ShouldBe(Constants.Zoom);
        }

        [Fact]
        public void Return_Smile_Network_Name()
        {
            var network = new Network("07021458945");
            var result = network.GetNetworkName();
            result.ShouldBe(Constants.Smile);
        }

        [Fact]
        public void Return_Multilinks_Network_Name()
        {
            var network = new Network("07027145894");
            var result = network.GetNetworkName();
            result.ShouldBe(Constants.Multilinks);
        }

        [Fact]
        public void Return_VisaFone_Network_Name()
        {
            var network = new Network("07025714589");
            var result = network.GetNetworkName();
            result.ShouldBe(Constants.Visafone);
        }


        [Fact]
        public void Return_StarComm_Network_Name()
        {
            var network = new Network("07029714589");
            var result = network.GetNetworkName();
            result.ShouldBe(Constants.Starcomms);
        }
    }
}
