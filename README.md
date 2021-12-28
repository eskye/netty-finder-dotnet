# NettyFinder .NET :rocket:

This is a .net verison of the original [netty-finder](https://github.com/BolajiAyodeji/netty-finder) that was written in JavaScript.

This script checks a Nigerian ☎️ telephone number and detects which network it belongs to, for .NET  version.

# Installation 

 Check the NettyFinder.Net on nuget: [https://www.nuget.org/packages/NettyFinder.Net](https://www.nuget.org/packages/NettyFinder.Net)
 
 <br/>
Install via the nuget package manager console:

`PM> Install-Package NettyFinder.Net`

<br/>
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
$>>s 9mobile

```

# About Author

This was originally built by [Bolaji Ayodeji](https://github.com/BolajiAyodeji) so all rights goes to him, I only interpreted the javascript code to C# and package to nuget.org

# Contribution
 
For now, I don't accept contributions except its from the javascript [netty_finder](https://github.com/BolajiAyodeji/netty-finder), so I suggest you contribute there. Any changes from there will be added to the .NET version


