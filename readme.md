# **Time Tracker** #

TimeTracker is small winform based utility which runs in background, capturing the time the current desktop environment is active. Active desktop means, user is logged in and is actively working on something. If the system goes to sleep or the system is shutdown or if the screen saver is active, then ***TimeTracker*** stops recording the time. Every-time ***TimeTracker*** goes to sleep or comes alive, it records the corresponding cumulative time into the database.

## **Utility SetUp** ##
* Checkout the source code
* Do a release build.
* Create a shortcut of the SystemEvent.exe(~/bin/release) and paste it in system "Startup" folder. This will ensure that, the utility automatically starts every-time system is restarted.

## **Database SetUp** ##
* In your local sql server instance, create an empty database called "TimeTracker".
* Then from command prompt, execute the following command : ***msbuild Migration.build***
* Ensure that you either have msbuild configured in your system environment path or use Visual Studio command prompt.

## **ToDo** ##
* Add Asp.net WebApi based restful api for retrieving data from database. 
* Add support for querying data via restful web api
* Use EAN(express.js, angular.js & node) stack for building UI client for the application.
* Add to UI various reports(possibly some sort of charting functionality)  
   