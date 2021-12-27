using System;
using Xunit;
using Shouldly;
namespace NettyFinder.Net.Tests
{
    public class NetworkTest
    {
        private Network network { get; }
        public NetworkTest()
        {
            network = new Network("080340506778");
        }

        [Fact]
        public void Network_Initialize_Should_Throw_Exception_With_Empty_Value()
        {
            _ = Should.Throw<ArgumentException>(() => new Network(string.Empty));

        }

        [Fact]
        public void Validate_PhoneNumber_Is_Not_Greater_Than_11_digit()
        {
           var network = new Network("08034050677");
           var result = network.ValidatePhoneNumber();
            result.ShouldBeTrue();
        }


        [Fact]
        public void Validate_PhoneNumber_Throw_Exception_If_Greater_Than_11_digit()
        {
            var network = new Network("08034050677999");
            Should.Throw<Exception>(() => network.ValidatePhoneNumber());
        }
    }
}
