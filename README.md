# NettyFinder .NET :rocket:

This is a .net verison of the original [netty-finder](https://github.com/BolajiAyodeji/netty-finder) that was written in JavaScript.

This script checks a Nigerian ☎️ telephone number and detects which network it belongs to, for .NET  version.

**Note that this library does not cover ported mobile phone numbers (Phone numbers that have been ported from one network provider to another network provider e.g Etisalat number ported to MTN number)**

# Installation 

 Check the NettyFinder.Net on nuget: [https://www.nuget.org/packages/NettyFinder.Net](https://www.nuget.org/packages/NettyFinder.Net)
 

Install via the nuget package manager console:

`PM> Install-Package NettyFinder.Net`
 
Install via the dotnet cli:

`> dotnet add package NettyFinder.Net` 


## GitHub

```bash
$ git clone https://github.com/eskye/netty-finder-dotnet.git
$ cd netty-finder-dotnet
```

# Usage

```C#

using NettyFinder.Net;

var network = new Network("08155737518");
var result = network.GetNetworkName();
Console.WriteLine(result);
$>> 9mobile

```

# About Author

This was originally built by [Bolaji Ayodeji](https://github.com/BolajiAyodeji) so all rights goes to him, I only interpreted the javascript code to C# and package to nuget.org

# Contribution
 You are free to raise an issue, PR and contribute on the C# project. You can also contribute on the javascript version of [netty_finder](https://github.com/BolajiAyodeji/netty-finder). 

# Road Map
At the moment, this library does not cover ported phone numbers (Phone numbers that have been ported from one network provider to another network provider e.g Etisalat number ported to MTN number), but there's a plan for it in the coming version.
