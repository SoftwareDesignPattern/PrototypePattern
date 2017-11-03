using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary _Salary = new Salary();
            _Salary.Basic = 5000;
            _Salary.HouseRentPercentage = 20.0;
            _Salary.ConveyancePercentage = 10.0;

            Salary _SalaryShallowCopy = _Salary.GetShallowCopy();
            _SalaryShallowCopy.Basic = 10000;



            Employee _Employee = new Employee();
            _Employee.Name = "Hasan";
            _Employee.Email = "e101@mail.com";
            _Employee.EmployeeSalary = _Salary;

            Console.WriteLine("Original : " + _Employee.Name + " " + _Employee.Email + " " + _Employee.EmployeeSalary.Basic);


            Employee _EmployeeShallowCopy = _Employee.GetShallowCopy();
            Employee __EmployeeDeepCopy = _Employee.GetDeepCopy();


            _EmployeeShallowCopy.Name = "Karim";
            _EmployeeShallowCopy.Email = "e102@gmail.com";
            _EmployeeShallowCopy.EmployeeSalary.Basic = 15000;

            __EmployeeDeepCopy.Name = "Humaira";
            __EmployeeDeepCopy.Email = "e103@gmail.com";
            __EmployeeDeepCopy.EmployeeSalary.Basic = 20000;

            Console.Read();
        }
    }
}
