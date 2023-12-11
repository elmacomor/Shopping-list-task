# Shopping-list-task
This task was done as a part of selection process for internship. I was working with .NET Core and React Typescript. The task was to make 5 shoppers and 5 items. User is able to make shopping lists for shoppers containing multiple items but one item can be found at 3 lists only. 
# InternshipTask

This task was done using .Net Core, React typescript and SQL database.

## How to install and run the project
Before you start the project, you will need following software installed on your machine:

Visual Studio 2022 : Make sure you have Visual Studio installed. If not, you can download and install it from the official website: https://visualstudio.microsoft.com/downloads/
Be sure to install .NET

SQL Database: Install SQL Server Management Studio (SSMS):

Download and install SQL Server Management Studio from the official Microsoft website: https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16
Follow the installation instructions provided.

Install SQL Server:
Download and install SQL Server. Download it from the official Microsoft website: https://www.microsoft.com/en-us/sql-server/sql-server-downloads

## After that you should do the following steps:

Adjust the Connection string in the TactaTask solution. Open appsettings.json and modify the data source instead of MY SERVER use localhost or your desktop db server.
  "ConnectionStrings": {
    "DefaultConnection": "Data Source="MY SERVER";Initial Catalog=TactaDB;Integrated Security=True; Encrypt=False"
  },

## Database migration:
To create the necessary tables in the database, you need to run the migrations.
First you need to add the migrations running the command: add-migration "migrationName"
Than type update-database. This handles the database schema migration and sets up the required tables.

To run the database migration, open a NuGet Package Manager-->Package Manager Console and run previous commands. 
Running the database migrations is a one-time setup process. You should only run it once, when setting up the application for the first time or when applying database schema changes.

## To insert data into tables execute the query provided-->SQLQuery1-fill the database

## Frontend
For the frontend part you are going to need Visual Studio Code: https://code.visualstudio.com/ and then
Install Node.js and npm:

Visit the official Node.js website: https://nodejs.org/.

Run the Project:
Once the setup is completed, you can run the application by executing the following command in the terminal:
npm install -to instal the libraries and packages
## npm run --Use npm run to start the React application
Be sure to run .net project and execute the query to insert data into database.
When you run the app you will be able to see 5 items and select with 5 shoppers from the DB. To add a product to the list you need to select a shopper and than click add to list button under an item.
To view product in the shopper list you need to select a shopper and than click on the button "Check the list".
