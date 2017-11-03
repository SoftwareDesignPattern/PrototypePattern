using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern
{
    [Serializable]
    class Employee
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public Salary EmployeeSalary { set; get; }

        public Employee GetShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public Employee GetDeepCopy()
        {
            MemoryStream _MemoryStream = new MemoryStream();
            BinaryFormatter _BinaryFormatter = new BinaryFormatter();
            _BinaryFormatter.Serialize(_MemoryStream, this);
            _MemoryStream.Seek(0, SeekOrigin.Begin);
            Employee copyEmployee = (Employee)_BinaryFormatter.Deserialize(_MemoryStream);
            return copyEmployee;
        }
    }
}
