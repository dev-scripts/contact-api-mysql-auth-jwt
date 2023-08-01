Simple CRUD web API created by using DotNet Core 7 to store contact details in MySQL Databse. Repository Design pattern is followed to create the API.

## Install tool globally
`dotnet tool install --global dotnet-ef` Install EF tool globally if you don't have.  

## Add First migration
`dotnet ef migrations add MyFirstMigration ` This will create a folder inside your project.

## Create table in the DB
`dotnet ef database update`. this command will create table in DB.# contact-api-mysql-auth-jwt
