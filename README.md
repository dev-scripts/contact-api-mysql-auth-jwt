## .NET 7 ContactWeb API 🔒 Authorization with JSON Web Tokens (JWT)

Created simple CRUD web API to store the contact detils of users in MySQL databse. Contact API is protected with JSON Web Tokens (JWT).
## Install tool globally
`dotnet tool install --global dotnet-ef` Install EF tool globally if you don't have.  

## Add First migration
`dotnet ef migrations add MyFirstMigration ` This will create a folder inside your project.

## Create table in the DB
`dotnet ef database update`. this command will create table in DB.# contact-api-mysql-auth-jwt

## Result
Once you run the project you will see attched scree as an output in web browser.

<img width="1394" alt="output" src="https://github.com/dev-scripts/contact-api-mysql-auth-jwt/assets/9651702/fbebdb88-ed0e-4574-9601-31dc1c46cd3d">

I have other two repo for same project

1. Contact API using MySQL database, no Authorization : https://github.com/dev-scripts/contact-api-mysql
2. Contact API using InMemoery database, no Authorization : https://github.com/dev-scripts/contact-api
