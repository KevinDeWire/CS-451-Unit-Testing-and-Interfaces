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
            Employee_Type = 30,
            Employee_Retirement_Matching = 4,
            Employee_Medical_Benefits = 10,
            Employee_PTO = 40
        };

        [TestInitialize]
        public void Create_Full_Time_Employee()
        {
            Result_Employee = Benefit_Actions.Create_Employee(100, 10);
        }

        [TestMethod]
        public void Check_Updated_Employee_ID()
        {
            int Expected_Emp = Expected_Employee.Employee_ID;
            int Result_Emp = Result_Employee.Employee_ID;
            Assert.AreEqual(Expected_Emp, Result_Emp);
        }

        [TestMethod]
        public void Check_Updated_Employee_Type()
        {
            Result_Employee = Benefit_Actions.Update_Employee_Type(Result_Employee, 30);
            int Expected_Emp = Expected_Employee.Employee_Type;
            int Result_Emp = Result_Employee.Employee_Type;
            Assert.AreEqual(Expected_Emp, Result_Emp);
        }

        [TestMethod]
        public void Check_Updated_Employee_Retirement_Matching()
        {
            Result_Employee = Benefit_Actions.Update_Employee_Retirement_Matching(Result_Employee, 4);
            int Expected_Emp = Expected_Employee.Employee_Retirement_Matching;
            int Result_Emp = Result_Employee.Employee_Retirement_Matching;
            Assert.AreEqual(Expected_Emp, Result_Emp);
        }

        [TestMethod]
        public void Check_Updated_Employee_Medical_Benefits()
        {
            Result_Employee = Benefit_Actions.Update_Employee_Medical_Benefits(Result_Employee, 10);
            int Expected_Emp = Expected_Employee.Employee_Medical_Benefits;
            int Result_Emp = Result_Employee.Employee_Medical_Benefits;
            Assert.AreEqual(Expected_Emp, Result_Emp);
        }

        [TestMethod]
        public void Check_Updated_Employee_PTO()
        {
            Result_Employee = Benefit_Actions.Update_Employee_PTO(Result_Employee, 40);
            int Expected_Emp = Expected_Employee.Employee_PTO;
            int Result_Emp = Result_Employee.Employee_PTO;
            Assert.AreEqual(Expected_Emp, Result_Emp);
        }
    }
}
