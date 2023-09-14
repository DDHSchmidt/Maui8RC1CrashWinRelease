# Maui8RC1CrashWinRelease
The latest Release Candidate for Maui 8 crashes on Windows when published in Release Mode

# Reproduction steps
- `dotnet restore CrashTestWin.csproj -p:PublishReadyToRun=false -r win-x64`
- `dotnet publish CrashTestWin.csproj -f net8.0-windows10.0.19041.0 -r win-x64 -c Release --no-restore --self-contained /p:RuntimeIdentifierOverride=win-x64 /p:PublishReadyToRun=false -p:WindowsAppSDKSelfContained=true /p:Platform=x64 /p:GenerateAppxPackageOnBuild=true /p:AppxPackageSigningEnabled=true /p:PackageCertificateThumbprint=<YourCertificateThumbPrintHere>`
- Start the app & enjoy crash

In Preview 7 this used to work aka: It produced a release build on Windows that didn't crash on starting the app.
Though if I manually change the <MauiVersion>-tag back to 8.0.0-preview.7.8842 the crash still occurs.
I presume the error has to do with the installed workload and/or .Net runtime on the target machine? Both of those are 8.0.0-rc.1.9171 for me

And for the love of god I couldn't find an easy guide on how to switch Workloads quickly after googling for 5 minutes so I gave up...