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
                    New_Employee.Employee_Retirement_Matching = 0;
                    New_Employee.Employee_Medical_Benefits = 0;
                    New_Employee.Employee_PTO = 0;
                    break;
                case 20:
                    New_Employee.Employee_Retirement_Matching = 2;
                    New_Employee.Employee_Medical_Benefits = 5;
                    New_Employee.Employee_PTO = 20;
                    break;
                case 30:
                    New_Employee.Employee_Retirement_Matching = 4;
                    New_Employee.Employee_Medical_Benefits = 10;
                    New_Employee.Employee_PTO = 40;
                    break;
                case 40:
                    New_Employee.Employee_Retirement_Matching = 5;
                    New_Employee.Employee_Medical_Benefits = 10;
                    New_Employee.Employee_PTO = 40;
                    break;
                default:
                    break;
            }
            return New_Employee;
        }

        public Employee Update_Employee_Type(Employee Updating_Employee, int New_Emp_Type)
        {
            Employee Employee = Updating_Employee;

            Employee.Employee_Type = New_Emp_Type;

            return Employee;
        }

        public Employee Update_Employee_Retirement_Matching(Employee Updating_Employee, int New_Emp_Ret_Matching)
        {
            Employee Employee = Updating_Employee;

            Employee.Employee_Retirement_Matching = New_Emp_Ret_Matching;

            return Employee;
        }

        public Employee Update_Employee_Medical_Benefits(Employee Updating_Employee, int New_Emp_Med_Benefits)
        {
            Employee Employee = new Employee();

            Employee.Employee_Medical_Benefits = New_Emp_Med_Benefits;

            return Employee;
        }

        public Employee Update_Employee_PTO(Employee Updating_Employee, int New_Emp_PTO)
        {
            Employee Employee = new Employee();

            Employee.Employee_PTO = New_Emp_PTO;

            return Employee;
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
                    Not_Found_Emp.Employee_Retirement_Matching = -1;
                    Not_Found_Emp.Employee_Medical_Benefits = -1;
                    Not_Found_Emp.Employee_PTO = -1;
                }

            return Not_Found_Emp;
        }
    }
}
