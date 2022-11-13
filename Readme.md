This project demonstrates how to conduct integration test on API using Specflow via self hosted API

Tools Used :
- TestContainers : https://dotnet.testcontainers.org/
- EntityFramework 
- Specflow : https://specflow.org/
- FluentAssertion : https://fluentassertions.com/

Run below commands to initilize local db to create tables :

- dotnet tool install --global dotnet-ef --version 7.0.0

- dotnet ef migrations add InitialCreate  --startup-project ..\SimpleAPI\  --verbose

- dotnet ef database update --project ..\SimpleAPI.DAL\ --startup-project ..\SimpleAPI\

