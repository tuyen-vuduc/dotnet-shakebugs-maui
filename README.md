# ShakeBugs for .NET MAUI

[ShakeBugs](https://www.shakebugs.com/) is a service to help you engage closely with your users where your users can give you directly bug reports and improvements when your app is live on stores.

## Prerequisites

- .NET 8
- Visual Studio or Visual Studio Code
- .NET workloads for .NET MAUI

## Steps to run the sample app

1/ Open `dotnet-shake-maui.sln` file
2/ Replace placeholders with your IDs and secrets
```cs
builder
    ...
    .UseShakeBugs(
        androidApiKey: "YOUR_ANDROID_API_KEY",
        iosApiKey: "YOUR_IOS_API_KEY",
        crashReportingEnabled: true
    )
    ...;
```

## Steps to use in your app

1/ Install the nuget package
```
<PackageReference Include="ShakeBugs.MAUI" Version="17.0.0" />
```
2/ Call `UseShakeBugs` in your `MauiProgram.cs`

## MAINTAINER

This project is maintained by [tuyen-vuduc](https://github.com/tuyen-vuduc) in his spare time.<br>

If you find this project is useful, please become a sponsor of the project and/or buy him a coffee.

[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/tuyen.vuduc)

OR

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tuyen-vuduc)

## LICENSE

The 3rd libraries will follow their associated licenses. This project itself is licensed under The 3-Clause BSD License.

Copyright 2024 tuyen-vuduc

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

3. Neither the name of the copyright holder nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS “AS IS” AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
