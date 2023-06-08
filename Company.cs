using System;

// namespace Classes
// {
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

       public List<Employee> EmployeeList {get; set;}

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            **The constructor will set the value of the public properties: Also if it's included as a paramater, when when you create an instance of the class, must include the properties set as parameters**

            **constructor must share the name of the class**

        */

       public Company (string name, DateTime date){
        Name = name;
        CreatedOn = date;
        EmployeeList = new List<Employee>();
       }

       public void PrintEmployeeInfo(Employee employee){
        Console.WriteLine($"\n{employee.FirstName} {employee.LastName} works for {this.Name} as {employee.Title} since {employee.StartDate}");
       }
    }
// }

   