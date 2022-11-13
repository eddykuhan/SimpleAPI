dotnet ef migrations add InitialCreate  --startup-project ..\SimpleAPI\  --verbose

dotnet ef database update --project ..\SimpleAPI.DAL\ --startup-project ..\SimpleAPI\