using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee_Benefits.Entities;
using Employee_Benefits.DomainServices;

namespace Employee_Benefits.Unit_Tests.EB.Core
{
    [TestClass]
    public class Employee_Update_Tests
    {
        Manage_Employee_Benefits Benefit_Actions = new Manage_Employee_Benefits();
        public Employee Result_Employee = new Employee();
        public Employee Expected_Employee = new Employee
        {
            Employee_ID = 100,
            Employee_Type = 10,
            Employee_Comp = 5,
            Employee_PTO = 30
        };

        [TestInitialize]
        public void Create_Full_Time_Employee()
        {
            Result_Employee = Benefit_Actions.Create_Employee(100, 10);
            Result_Employee = Benefit_Actions.Update_Employee(100, 10, 5, 30);
        }

        [TestMethod]
        public void Check_Updated_Full_Time_Employee_ID()
        {
            int Expected_Emp_ID = Expected_Employee.Employee_ID;
            int Result_Emp_ID = Result_Employee.Employee_ID;
            Assert.AreEqual(Expected_Emp_ID, Result_Emp_ID);
        }

        [TestMethod]
        public void Check_Updated_Full_Time_Employee_Type()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_Type;
            int Result_Emp_Type = Result_Employee.Employee_Type;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }

        [TestMethod]
        public void Check_Updated_Full_Time_Employee_Compensation()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_Comp;
            int Result_Emp_Type = Result_Employee.Employee_Comp;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }

        [TestMethod]
        public void Check_Updated_Full_Time_Employee_PTO()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_PTO;
            int Result_Emp_Type = Result_Employee.Employee_PTO;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }
    }
}
