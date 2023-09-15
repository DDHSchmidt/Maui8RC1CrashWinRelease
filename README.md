# Maui8RC1CrashWinRelease
The latest Release Candidate for Maui 8 crashes on Windows when published in Release Mode

# Reproduction steps (Update 1)
- `dotnet restore CrashTestWin.csproj -r win10-x64 -p:TargetFramework=net8.0-windows10.0.19041.0`
- Result: `NETSDK1083: The specified RuntimeIdentifier 'win10-x64' is not recognized`

In Preview 7 this used to work aka: It produced a release build on Windows that didn't crash on starting the app.
Though if I manually change the <MauiVersion>-tag back to 8.0.0-preview.7.8842 the crash still occurs.
I presume the error has to do with the installed workload and/or .Net runtime on the target machine? Both of those are 8.0.0-rc.1.9171 for me

And for the love of god I couldn't find an easy guide on how to switch Workloads quickly after googling for 5 minutes so I gave up...

#Update 1
After assistance from Mr. Leibowitz the initial problem went away, but the build problems on our original project persisted. They seem to stem from the included references to other projects (class libraries).
I've updated the reproduction project to reflect that.
Right now, `dotnet restore` will error with the message NETSDK1083