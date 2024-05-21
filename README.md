# ShakeBugs for .NET MAUI

## Prerequisites

- .NET 8
- Visual Studio or Visual Studio Code
- .NET workloads for .NET MAUI

## Android

 This quick start is based on [the official quick start guide](https://developers.facebook.com/docs/facebook-login/android/) from Facebook. It will guide you how to use Facebook Android SDK binding libraries created by [tuyen-vuduc](https://github.com/tuyen-vuduc). The source of the binding libraries can be found [here](https://github.com/tuyen-vuduc/dotnet-binding-utils).

### Steps to run the sample app

1/ Create a Facebook app

> NOTE: You can just use one of your existing apps

2/ Navigate to the quickstart for Android platform

```
https://developers.facebook.com/apps/{YOUR_APP_ID}/fb-login/quickstart/?use_case_enum=FB_LOGIN
```

3/ Achieve the debug keystore's keyhash

Mine is `Yntws4c3jc3MCvJ256RHPr/0T5k=`

**On Windows**

```bash
keytool -exportcert -alias androiddebugkey -keystore "C:\Users\{YOUR_USER_NAME}\AppData\Local\Xamarin\Mono for Android\debug.keystore" | openssl sha1 -binary | openssl base64
```

**On Mac

```
keytool -list -v -keystore ~/Library/Developer/Xamarin/Keystore/androiddebugkey/androiddebugkey.keystore -alias androiddebugkey -storepass android -keypass android  | openssl sha1 -binary | openssl base64
```

4/ Add the generated keyhash to Facebook app dashboard and save

5/ Define string resources for your app in `facebook_dev.xml`

5.a/ File location

```
|--src
    |-- Dotnet.Facebook.Android.QuickStart
        |-- Resources
            |-- values
                |-- facebook_dev.xml
```

5.b/ File content

```
<resources>
    <string name="facebook_app_id">YOUR_APP_ID</string>
    <string name="fb_login_protocol_scheme">fbYOUR_APP_ID</string>
    <string name="facebook_client_token">YOUR_APP_SECRET</string>    
</resources>

```

6/ Run up and try out the sample app

### Steps to use in your app

1/ Add required NuGet packages

> We need `Xamarin.Kotlin.StdLib.Jdk8` added directly because of version conflicts.

```
<PackageReference Include="Com.Facebook.Android.FacebookAndroidSdk" Version="17.0.0" />
<PackageReference Include="Xamarin.Kotlin.StdLib.Jdk8" Version="1.9.23.1" />
```

2/ Add other required features and check out

## iOS

TBD

## MAINTAINER

This project is maintained by [tuyen-vuduc](https://github.com/tuyen-vuduc) in his spare time.<br>

If you find this project is useful, please become a sponsor of the project and/or buy him a coffee.

[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/tuyen.vuduc)

OR

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tuyen-vuduc)

## LICENSE

The 3rd libraries will follow their associated licenses. This project itself is licensed under MIT license.

Copyright 2024 tuyen-vuduc

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
