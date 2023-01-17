# Eau Claire's Hair Salon

#### Database Basics Independent Project 

## Contributors

* Teddy Atkinson

## Description
Simple one to many database relationship using mySQL displayed in a MVC application format. Relationship represented with clients to salon stylists.

## Technologies Used

* _C#_
* _Html_
* _CSS_
* _ASP .NET6_
* _MySQL_
* _MVC_
* _Entity Framework Core_

## Setup/Installation Requirements

* Install MySQL Community Server and MySQL Workbench. Follow the instructions _[here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql/)_.
* Clone down the git repo ```https://github.com/TeddyAtkinson/SalonOTM.git``` to the ```desktop``` directory
* Open the project with VSCode or a different source code editor.
* Restore required packages: change directory to ```HairSalon``` and restore with ```$ dotnet restore```
* While in the ```HairSalon``` directory use ```$ dotnet build``` to build the program.
* While in the ```HairSalon``` directory use ```$ dotnet watch run``` to run the program in the browser with a watcher.

## Database Setup

* To connect your database, create file ```appsettings.json``` in the production directory ```Salon```
* Fill in the file with the following code: Be sure to replace the required fields marked with ```[]``` that must contain the database name, user id, and password.
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DB-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* To include this projects data and structure, import the ```teddy_atkinson.sql``` dump file into your named database.

## Known Bugs

* None

## License
Copyright (c) 2022 Teddy Atkinson
_[MIT](https://choosealicense.com/licenses/mit/)_