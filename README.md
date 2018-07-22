[![Build Status](https://travis-ci.com/muratsplat/dummy3D.svg?branch=master)](https://travis-ci.com/muratsplat/dummy3D)
# Dummy3D
This is dummy 3D Secure service for test cases. This service is useful for payment gateway. You can use it to complate 3D user journey like as Visa or Master ACS service without no any effors.

## Requiretments
- Docker (optinal)
- .NetCore SDK >= 3.2.300

## How to configure project to install all dependencies ?

```sh
 $ git clone git@github.com:muratsplat/dummy3D.git
 cd  dummy3D
 dotnet restore
  Restore completed in 104.23 ms for /Users/foo/code/projects/Dummy3D/Test/Test.csproj.
  Restore completed in 24.45 ms for /Users/foo/code/projects/Dummy3D/Test/Test.csproj.
  Restore completed in 44.2 ms for /Users/foo/code/projects/Dummy3D/App/App.csproj.
  dotnet publish -c Release -o out

```

## How to build project ?

```sh
  $ dotnet publish -c Release -o out
  dotnet App/out/App.dll
    info: Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager[0]
      User profile is available. Using '/Users/foo/.aspnet/DataProtection-Keys' as key repository; keys will not be encrypted at rest.
    Hosting environment: Production
    Content root path: /Users/foo/code/projects/Dummy3D
    Now listening on: http://localhost:5000
    Now listening on: https://localhost:5001
    Application started. Press Ctrl+C to shut down.
```

Now project is working now and you can open above URL's on your web browser.

## Todo
- Complate project
- Adds deployment scripts
- Adds SSL support via Let's Encrypt
- Adds storing transaction on database
- Adds Account managment to serve authorizatiob based on API Keys
- Publish project to a server
