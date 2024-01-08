# Guide on how to run the project
# Step 1
-Open Visual Studio

-Clone the github project repository

-https://github.com/VictorPhoswa/ProductOrder

# Step 2
-Connect a database to the project from visual studio

-Open AppSettings.json

-Update the ApplicationDbContext String with your database connection string --save

# Step 3
-Delete the Migrations folder

-Open Package Manager Console apply the following commands

-Create new migration:  Add-Migration Initial

-Create a new database: Update-database

# NB: Make sure you are working on a clean database, so that there is no conflict between tables.

# NB: The is data that is used to initialize the project, after creating the database the should be data seeded into it.

# Step 4
-Run your application

-Happy Hacking !!!
