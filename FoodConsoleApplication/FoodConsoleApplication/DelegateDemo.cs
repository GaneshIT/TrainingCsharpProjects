using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodConsoleApplication
{
    class Employee
    {
        public void Data()
        {
            //GetEmployees;
        }
        public Employee GetEmployees()
        {
            return new Employee();
        }
        public List<Employee> GetEmployeeList()
        {
            return new List<Employee> { new Employee() };
        }
    }
    //Declare Delegate
    public delegate int CalculatorDelegate(int x, int y);
    internal class Calculator
    {
        //Create Delegate Reference
        CalculatorDelegate delegateObj = null;

        //Depending upon request we will assign Delegate
        public CalculatorDelegate GetDelegateRef(int intoperation)
        {
            //And Finally assign based on request
            switch (intoperation)
            {
                case 1:
                    delegateObj = Add;//creating reference method
                    break;
                case 2:
                    delegateObj = Sub;
                    break;
                case 3:
                    delegateObj = Multi;
                    break;
                case 4:
                    delegateObj = Div;
                    break;
                default: break;
            }
            return delegateObj;
        }
        public int Add(int x, int y) { return x + y; }
        public int Sub(int x, int y) { return x - y; }
        public int Multi(int x, int y) { return x * y; }
        public int Div(int x, int y) { return x / y; }
    }
}
