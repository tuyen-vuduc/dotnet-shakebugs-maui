dotnet nuget locals -c all

# Build to trigger gradle process
dotnet build -t:Clean,Rebuild src/ShakeBugsMauiQs/ShakeBugsMauiQs.csproj

dotnet pack -c Release -t:Clean,Rebuild src/ShakeBugs.MAUI/ShakeBugs.MAUI.csproj --output $PWD/nugets -p:AndroidSdkDirectory=$ANDROID_HOME