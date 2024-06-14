dotnet nuget locals -c all
dotnet pack -c Release -t:Clean,Rebuild src/ShakeBugs.MAUI/ShakeBugs.MAUI.csproj --output $PWD/nugets -p:AndroidSdkDirectory=$ANDROID_HOME