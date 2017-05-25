using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using PeopleProTraining.Controllers;

namespace PeopleProTraining.Test.Controllers
{
    [TestClass]
    public class EmployeesControllerTests
    {
        [TestMethod]
        public void TestIndexView()
        {
            var controller = new EmployeesController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
