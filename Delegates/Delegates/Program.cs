using System;
using System.Collections.Generic;

namespace Delegates
{
    // este delegate pode ser apontado para qualquer função que tenha a mesma assinatura 
    // delegates são ponteiros de função type safe
    //  type safe -> siginifica que se a assinatura entre o método e a delegate não forem iguais, dará erro ao compilar
    public delegate void HelloFunctionDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            // o método Hello é passado como parâmetro pois possui a mesma assinatura entre a delegato e o método
            //HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            //del("Chamando a função hello");
            //Console.WriteLine("Hello World!");

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { ID = 101, Name = "name 1", Salary = 5000, Experience = 5 });
            empList.Add(new Employee { ID = 101, Name = "name 2", Salary = 4000, Experience = 4 });
            empList.Add(new Employee { ID = 101, Name = "name 3", Salary = 6000, Experience = 6 });
            empList.Add(new Employee { ID = 101, Name = "name 4", Salary = 3000, Experience = 3 });
            Employee.PromoteEmployee(empList);
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (var item in employeeList)
            {
                if(item.Experience > 5)
                {
                    Console.WriteLine(item.Name + " promoted");
                }
            }
        }
    }
}
