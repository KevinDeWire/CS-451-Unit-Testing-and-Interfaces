using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee_Benefits.Entities;
using Employee_Benefits.DomainServices;

namespace Employee_Benefits.Unit_Tests.EB.Core
{
    [TestClass]
    public class Employee_Creation_Tests
    {
    }

    [TestClass]
    public class Full_Time_Employee_Tests : Employee_Creation_Tests
    {
        Manage_Employee_Benefits Benefit_Actions = new Manage_Employee_Benefits();
        public Employee Result_Employee = new Employee();
        public Employee Expected_Employee = new Employee
        {
            Employee_ID = 100,
            Employee_Type = 10,
            Employee_Comp = 10,
            Employee_PTO = 40
        };

        [TestInitialize]
        public void Create_Full_Time_Employee()
        {
            Result_Employee = Benefit_Actions.Create_Employee(100, 10);
        }
        
        [TestMethod]
        public void Check_Full_Time_Employee_Type()
        {            
            int Expected_Emp_Type = Expected_Employee.Employee_Type;
            int Result_Emp_Type = Result_Employee.Employee_Type;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }

        [TestMethod]
        public void Check_Full_Time_Employee_Compensation()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_Comp;
            int Result_Emp_Type = Result_Employee.Employee_Comp;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }

        [TestMethod]
        public void Check_Full_Time_Employee_PTO()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_PTO;
            int Result_Emp_Type = Result_Employee.Employee_PTO;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }
    }

    [TestClass]
    public class Part_Time_Employee_Tests : Employee_Creation_Tests
    {
        Manage_Employee_Benefits Benefit_Actions = new Manage_Employee_Benefits();
        public Employee Result_Employee = new Employee();
        public Employee Expected_Employee = new Employee
        {
            Employee_ID = 200,
            Employee_Type = 20,
            Employee_Comp = 5,
            Employee_PTO = 20
        };

        [TestInitialize]
        public void Create_Part_Time_Employee()
        {
            Result_Employee = Benefit_Actions.Create_Employee(200, 20);
        }

        [TestMethod]
        public void Check_Part_Time_Employee_Type()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_Type;
            int Result_Emp_Type = Result_Employee.Employee_Type;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }

        [TestMethod]
        public void Check_Part_Time_Employee_Compensation()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_Comp;
            int Result_Emp_Type = Result_Employee.Employee_Comp;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }

        [TestMethod]
        public void Check_Part_Time_Employee_PTO()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_PTO;
            int Result_Emp_Type = Result_Employee.Employee_PTO;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }
    }

    [TestClass]
    public class Temporary_Employee_Tests : Employee_Creation_Tests
    {
        Manage_Employee_Benefits Benefit_Actions = new Manage_Employee_Benefits();
        public Employee Result_Employee = new Employee();
        public Employee Expected_Employee = new Employee
        {
            Employee_ID = 300,
            Employee_Type = 30,
            Employee_Comp = 0,
            Employee_PTO = 0
        };

        [TestInitialize]
        public void Create_Temporary_Employee()
        {
            Result_Employee = Benefit_Actions.Create_Employee(300, 30);
        }

        [TestMethod]
        public void Check_Temporary_Employee_Type()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_Type;
            int Result_Emp_Type = Result_Employee.Employee_Type;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }

        [TestMethod]
        public void Check_Temporary_Employee_Compensation()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_Comp;
            int Result_Emp_Type = Result_Employee.Employee_Comp;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }

        [TestMethod]
        public void Check_Temporary_Employee_PTO()
        {
            int Expected_Emp_Type = Expected_Employee.Employee_PTO;
            int Result_Emp_Type = Result_Employee.Employee_PTO;
            Assert.AreEqual(Expected_Emp_Type, Result_Emp_Type);
        }
    }
}
