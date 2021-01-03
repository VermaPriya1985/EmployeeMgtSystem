<b> <u>Employee Management System </u></b>

Employee Management System lets you keep track of employees information. There are two types of users admin and employee. Employee can request leave, concern and view holidays. Admin can add holidays, approve/disapprove leave status submitted by employees.This application is built using .NET Core 3.1, C#, MVC, Entity Framework and PostgreSql.
Components
 
Engine The engine, or logic layer of the application, consists of 'Plants', and 'Waterings' models. Each plant can have many waterings associated with it. Any time the user waters a plant, a 'Watering' instance is added to the plant's collection of waterings.
The NextWateringDate for a plant is calculated by taking the most recent watering date, and adding the DaysBetweenWaterings value onto it. This is displayed to the user.
The 'Garden' class is the main engine class. This is where the main actions of the application are defined. This includes CRUD operations on the Plant object, as well as the ability to Water a plant. c



