// See https://aka.ms/new-console-template for more information
using _1Singleton;

Singleton fromTeachaer = Singleton.GetInstance;
fromTeachaer.PrintDetails("From Teacher");

Singleton fromStudent = Singleton.GetInstance;
fromStudent.PrintDetails("From Student");

/*    

Some Real-time scenarios where you can use the Singleton Design Pattern:

Service Proxies: As we know invoking a Service API is an extensive operation in an application.
The process that taking most of the time is creating the Service client in order to invoke the service API. 
If you create the Service proxy as Singleton then it will improve the performance of your application.

Facades: You can also create Database connections as Singleton which can improve the performance of the application.

Logs: In an application, performing the I/O operation on a file is an expensive operation. 
If you create your Logger as Singleton then it will improve the performance of the I/O operation.

Data sharing: If you have any constant values or configuration values then you can keep these values in Singleton 
So that these can be read by other components of the application.

Caching: As we know fetching the data from a database is a time-consuming process. 
In your application, you can cache the master and configuration in memory which will avoid the DB calls. 
In such situations, the Singleton class can be used to handle the caching with thread synchronization in an efficient 
manner which drastically improves the performance of the application. 

Disadvantages:
1. Unit testing is very difficult because it introduces a global state into an application.
2. It reduces the potential for parallelism within a program because to access the singleton instance in a multi-threaded environment, 
   you need to serialize the object by using locking.

*/