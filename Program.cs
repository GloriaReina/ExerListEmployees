using System;

// namespace Classes
// {
    class Program
    {
        static void Main(string[] args)
        {
            DateTime companyStartDate = new DateTime(2003, 5, 1);
            // Create an instance of a company. Name it whatever you like, must include property as parameter bc required in the constructor
            Company dotNet = new Company("Dotnet", companyStartDate);

            // Create three employees
            Employee employee1 = new Employee {
                FirstName = "John",
                LastName = "Doe",
                Title = "Developer",
                StartDate = new DateTime(2023, 5,5)
            };
             Employee employee2 = new Employee {
                FirstName = "Sil",
                LastName = "Beem",
                Title = "Manager",
                StartDate = new DateTime(2022, 1,5)
            };
             Employee employee3 = new Employee {
                FirstName = "Catherine",
                LastName = "Reine",
                Title = "Data Scientist",
                StartDate = new DateTime(2023, 5,30)
            };
            // Assign the employees to the company
            dotNet.EmployeeList.Add(employee1);
            dotNet.EmployeeList.Add(employee2);
            dotNet.EmployeeList.Add(employee3);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
           dotNet.EmployeeList.ForEach(e => dotNet.PrintEmployeeInfo(e));
        }
    }
// }
