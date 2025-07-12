rem remove existing bundle
del efbundle
rem re bundle the database migrations and all that good stuff for linux
dotnet ef migrations bundle --self-contained -r linux-arm64
rem copy the efbundle file into the publish directory
copy efbundle .\bin\Release\net9.0\linux-arm64\publish\
rem Update the database on linux with .\efbundle (ran on its own like a exe file)
ssh pi@raspberrypi ".\efbundle"