# 24h-Code-Challenge

Project Setup:

1) In your local SQL Server create database name '24h-Code-Challenge'.
	a) In the solution root folder locate assets folder and extract all the csv files from the zip that you will find in there.
	b) Then using SSMS Import the CSVs in yout created database.
2) Clone the solution and open it.
3) Locate the appsettings json file, update the connection string section.
	a)Server=[server_instance];Database=[database_name];Trusted_Connection=True;TrustServerCertificate=True;
4) Then open Package Manager Console
	a) execute Update-Database. This will update your local DB base on the entity from the solution.
5) Press F5 this will open the Swagger UI. So we can preview how the available endpoints works.