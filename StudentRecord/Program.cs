// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Employee Details");

Console.WriteLine("Enter Employee ID");
int EmployeeID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Employee Name");
string Name = Console.ReadLine();
Console.WriteLine("Enter Employee Salary");
int Salary = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Employee Address");
string Address = Console.ReadLine();
Console.WriteLine("Enter Employee Department");
string Department = Console.ReadLine();

//Display the Entered Employee Details
Console.WriteLine("\nEntered Employee Details are as Follows:");
Console.WriteLine($"Employee ID is: {EmployeeID}");
Console.WriteLine($"Employee Name is: {Name}");
Console.WriteLine($"Employee Salary is: {Salary}");
Console.WriteLine($"Employee Address is: {Address}");
Console.WriteLine($"Employee Department is: {Department}");