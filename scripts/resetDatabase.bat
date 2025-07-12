rem Reset the database migrations
dotnet ef database update 0
dotnet ef migrations add Initialize
rem Update the database
dotnet ef database update