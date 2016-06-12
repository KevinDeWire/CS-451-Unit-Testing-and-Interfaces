using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Benefits.Entities;

namespace Employee_Benefits.DomainServices
{
    public class Manage_Employee_Benefits
    {
        public Employee Create_Employee(int Emp_ID, int Emp_Type)
        {
            var New_Employee = new Employee();
            New_Employee.Employee_ID = Emp_ID;
            New_Employee.Employee_Type = Emp_Type;
            switch (New_Employee.Employee_Type)
            {
                case 10:
                    New_Employee.Employee_Comp = 10;
                    New_Employee.Employee_PTO = 40;
                    break;
                case 20:
                    New_Employee.Employee_Comp = 5;
                    New_Employee.Employee_PTO = 20;
                    break;
                case 30:
                    New_Employee.Employee_Comp = 0;
                    New_Employee.Employee_PTO = 0;
                    break;
                default:
                    break;
            }
            return New_Employee;
        }

        public Employee Update_Employee(int Emp_ID, int Emp_Type, int Emp_Comp, int Emp_PTO)
        {
            var New_Employee = new Employee();

            New_Employee.Employee_ID = Emp_ID;
            New_Employee.Employee_Type = Emp_Type;
            New_Employee.Employee_Comp = Emp_Comp;
            New_Employee.Employee_PTO = Emp_PTO;

            return New_Employee;
        }

        public Employee Find_Employee(Employee[] Emp_List, int Emp_ID)
        {
            Employee Not_Found_Emp = new Employee();

            foreach (Employee Emp in Emp_List)
                if (Emp.Employee_ID == Emp_ID)
                    return Emp;
                else
                {
                    Not_Found_Emp.Employee_ID = -1;
                    Not_Found_Emp.Employee_Type = -1;
                    Not_Found_Emp.Employee_Comp = -1;
                    Not_Found_Emp.Employee_PTO = -1;
                }

            return Not_Found_Emp;
        }
    }
}
