using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee_Benefits.Entities;
using Employee_Benefits.DomainServices;

namespace Employee_Benefits.Unit_Tests.EB.Core
{
    [TestClass]
    public class Employee_Record_Search
    {
        Manage_Employee_Benefits Benefit_Actions = new Manage_Employee_Benefits();
        public Employee[] Employee_List = new Employee[3];
        public Employee Result_Employee = new Employee();
        public Employee Expected_Employee = new Employee
        {
            Employee_ID = 300,
            Employee_Type = 30,
            Employee_Retirement_Matching = 4,
            Employee_Medical_Benefits = 10,
            Employee_PTO = 40
        };

        [TestInitialize]
        public void Create_Employee_List()
        {
            Employee_List[0] = new Employee();
            Employee_List[0].Employee_ID = 400;
            Employee_List[0].Employee_Type = 40;
            Employee_List[0].Employee_Retirement_Matching = 5;
            Employee_List[0].Employee_Medical_Benefits = 10;
            Employee_List[0].Employee_PTO = 40;

            Employee_List[0] = new Employee();
            Employee_List[0].Employee_ID = 300;
            Employee_List[0].Employee_Type = 30;
            Employee_List[0].Employee_Retirement_Matching = 4;
            Employee_List[0].Employee_Medical_Benefits = 10;
            Employee_List[0].Employee_PTO = 40;

            Employee_List[1] = new Employee();
            Employee_List[1].Employee_ID = 200;
            Employee_List[1].Employee_Type = 20;
            Employee_List[1].Employee_Retirement_Matching = 2;
            Employee_List[1].Employee_Medical_Benefits = 5;
            Employee_List[1].Employee_PTO = 20;

            Employee_List[2] = new Employee();
            Employee_List[2].Employee_ID = 100;
            Employee_List[2].Employee_Type = 10;
            Employee_List[2].Employee_Retirement_Matching = 0;
            Employee_List[2].Employee_Medical_Benefits = 0;
            Employee_List[2].Employee_PTO = 0;
            
        }

        [TestMethod]
        public void Check_Valid_Found_Employee_ID()
        {
            Result_Employee = Benefit_Actions.Find_Employee(Employee_List, 300);

            int Expected_Emp_ID = Expected_Employee.Employee_ID;
            int Result_Emp_ID = Result_Employee.Employee_ID;
            Assert.AreEqual(Expected_Emp_ID, Result_Emp_ID);
        }

        [TestMethod]
        public void Check_Invalid_Found_Employee_ID()
        {
            Result_Employee = Benefit_Actions.Find_Employee(Employee_List, 500);

            int Expected_Emp_ID = -1;
            int Result_Emp_ID = Result_Employee.Employee_ID;
            Assert.AreEqual(Expected_Emp_ID, Result_Emp_ID);
        }
    }
}
