using System;

namespace C_assignmet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            String Name = Console.ReadLine();

            Console.WriteLine("Enter Department Name");
            String DepartmentName = Console.ReadLine();

            var employee = new Employee(id, Name, DepartmentName);
            employee.IdCalled += OnIdCalled;
            employee.NameCalled += OnNameCalled;
            employee.DeptNameCalled += OnDeptNameCalled;


            Console.WriteLine($"Id:{employee.GetId()}");
            Console.WriteLine($"Name:{employee.GetName()}");
            Console.WriteLine($"Department Name:{employee.GetDepartmentName()}");

        }
        static void OnIdCalled(object sender, EventArgs e)
        {
            Console.WriteLine("GetId() called");

        }
        static void OnNameCalled(object sender, EventArgs e)
        {
            Console.WriteLine("GetName() Called");
        }
        static void OnDeptNameCalled(object sender, EventArgs e)
        {
            Console.WriteLine("GetDepartmentName() Called");
        }
    }
}
