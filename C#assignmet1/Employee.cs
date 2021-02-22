using System;

namespace C_assignmet1
{
    public delegate void IdCalledDelegate(object sender, EventArgs args);

    public class Employee
    {
        private int id;
        private string name;
        private string departmentName;

        public Employee(int id, string name, string departmentName)
        {
            this.id = id;
            this.name = name;
            this.departmentName = departmentName;
        }

        public event IdCalledDelegate IdCalled;
        public event IdCalledDelegate NameCalled;

        public event IdCalledDelegate DeptNameCalled;

        public int GetId()
        {
            IdCalled(this, new EventArgs());
            return id;
        }

        public String GetName()
        {
            NameCalled(this, new EventArgs());
            return name;
        }

        public String GetDepartmentName()
        {
            DeptNameCalled(this, new EventArgs());
            return departmentName;
        }

        public void Set(int id)
        {
            this.id = id;
        }
        public void Set(String Name)
        {
            this.name = Name;
        }
        public void Set(int id,String Name,String DepartmentName)
        {
            this.departmentName = DepartmentName;
        }

        
    }
}